using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace StokSatis.DAL
{
    public class ProductDAL
    {
        Veritabani db = new Veritabani();
        public void UrunEkle(string ad, int stok, decimal fiyat)
        {
            using (var baglanti = db.GetConnection())
            {
                baglanti.Open(); 
                                 
                string sorgu = "INSERT INTO urunler (urun_adi, stok_adedi, fiyat) VALUES (@ad, @stok, @fiyat)";

                MySqlCommand cmd = new MySqlCommand(sorgu, baglanti);
                cmd.Parameters.AddWithValue("@ad", ad);
                cmd.Parameters.AddWithValue("@stok", stok);
                cmd.Parameters.AddWithValue("@fiyat", fiyat);

                cmd.ExecuteNonQuery();  
            }
        }

        public DataTable UrunleriGetir()
        {
            using (var baglanti = db.GetConnection())
            {
                baglanti.Open();
                string sorgu = "SELECT * FROM urunler"; 
                MySqlDataAdapter adapter = new MySqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                adapter.Fill(dt); 
                return dt;
            }
        }

        public DataTable KritikStoklariGetir()
        {
            using (var baglanti = db.GetConnection())
            {
                baglanti.Open();
                
                string sorgu = "SELECT urun_adi, stok_adedi, fiyat FROM urunler WHERE stok_adedi < 20";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }


        public void StokGuncelle(int urunId, int satilanMiktar)
        {
            using (var baglanti = db.GetConnection())
            {
                baglanti.Open();
                
                string sorgu = "UPDATE urunler SET stok_adedi = stok_adedi - @miktar WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sorgu, baglanti);
                cmd.Parameters.AddWithValue("@miktar", satilanMiktar);
                cmd.Parameters.AddWithValue("@id", urunId);
                cmd.ExecuteNonQuery();
            }
        }


        public void SatisKaydet(int urunId, int miktar, int musteriId)
        {
            using (var baglanti = db.GetConnection())
            {
                baglanti.Open();

                
                string satisSorgu = "INSERT INTO satislar (urun_id, miktar, musteri_id) VALUES (@uId, @miktar, @mId)";
                MySqlCommand cmdSatis = new MySqlCommand(satisSorgu, baglanti);
                cmdSatis.Parameters.AddWithValue("@uId", urunId);
                cmdSatis.Parameters.AddWithValue("@miktar", miktar);
                cmdSatis.Parameters.AddWithValue("@mId", musteriId); 
                cmdSatis.ExecuteNonQuery();

                
                string stokSorgu = "UPDATE urunler SET stok_adedi = stok_adedi - @miktar WHERE id = @id";
                MySqlCommand cmdStok = new MySqlCommand(stokSorgu, baglanti);
                cmdStok.Parameters.AddWithValue("@miktar", miktar);
                cmdStok.Parameters.AddWithValue("@id", urunId);
                cmdStok.ExecuteNonQuery();
            }
        }


        public DataTable TumUrunleriGetir()
        {
            using (var baglanti = db.GetConnection())
            {
                baglanti.Open();
                string sorgu = "SELECT id, urun_adi FROM urunler";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public int StokAdediOgren(int urunId)
        {
            using (var baglanti = db.GetConnection())
            {
                baglanti.Open();
                string sorgu = "SELECT stok_adedi FROM urunler WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sorgu, baglanti);
                cmd.Parameters.AddWithValue("@id", urunId);

                // ExecuteScalar tek bir değer (stok sayısı) döndürür
                object sonuc = cmd.ExecuteScalar();
                return Convert.ToInt32(sonuc);
            }
        }

        public void UrunGuncelle(int id, string ad, decimal fiyat, int stok)
        {
            using (var baglanti = db.GetConnection())
            {
                baglanti.Open();
                string sorgu = "UPDATE urunler SET urun_adi=@ad, fiyat=@fiyat, stok_adedi=@stok WHERE id=@id";

                MySqlCommand cmd = new MySqlCommand(sorgu, baglanti);
                cmd.Parameters.AddWithValue("@ad", ad);
                cmd.Parameters.AddWithValue("@fiyat", fiyat);
                cmd.Parameters.AddWithValue("@stok", stok);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
