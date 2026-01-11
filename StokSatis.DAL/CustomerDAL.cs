using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace StokSatis.DAL
{
   public class CustomerDAL
    {

        
        Veritabani db = new Veritabani();

       
        public void MusteriEkle(string ad, string tel, string adres, string tip)
        {
            using (var baglanti = db.GetConnection())
            {
                baglanti.Open();
                string sorgu = "INSERT INTO musteriler (ad_soyad, telefon, adres, musteri_tipi) VALUES (@ad, @tel, @adres, @tip)";

                MySqlCommand cmd = new MySqlCommand(sorgu, baglanti);
                cmd.Parameters.AddWithValue("@ad", ad);
                cmd.Parameters.AddWithValue("@tel", tel);
                cmd.Parameters.AddWithValue("@adres", adres);
                cmd.Parameters.AddWithValue("@tip", tip);

                cmd.ExecuteNonQuery();
            }
        }

        
        public DataTable MusterileriGetir()
        {
            using (var baglanti = db.GetConnection())
            {
                baglanti.Open();
                string sorgu = "SELECT * FROM musteriler";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sorgu, baglanti);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }



    }
}
