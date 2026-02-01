using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace StokSatis.DAL
{
    public class ReportDAL
    {

        Veritabani db = new Veritabani();

        
        public DataTable TumSatislariGetir()
        {
            using (var baglanti = db.GetConnection())
            {
                baglanti.Open();

                
                string sorgu = @"
                    SELECT 
                        s.id AS SatisNo,
                        m.ad_soyad AS Musteri,
                        u.urun_adi AS Urun,
                        u.fiyat AS BirimFiyat,
                        s.miktar AS Adet,
                        (s.miktar * u.fiyat) AS ToplamTutar,
                        s.satis_tarihi AS Tarih
                    FROM satislar s
                    JOIN urunler u ON s.urun_id = u.id
                    JOIN musteriler m ON s.musteri_id = m.id
                    ORDER BY s.satis_tarihi DESC"; 

                MySqlDataAdapter adapter = new MySqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public string EnCokSatanUrunuBul()
        {
            using (var baglanti = db.GetConnection())
            {
                baglanti.Open();

                // Bu sorgu: Satışları gruplar, miktarları toplar ve en yükseği en tepeye alır
                string sorgu = @"
            SELECT u.urun_adi, SUM(s.miktar) as ToplamAdet
            FROM satislar s
            JOIN urunler u ON s.urun_id = u.id
            GROUP BY u.urun_adi
            ORDER BY ToplamAdet DESC
            LIMIT 1"; // Sadece 1 tane (Şampiyonu) getir

                MySqlCommand cmd = new MySqlCommand(sorgu, baglanti);
                MySqlDataReader okuyucu = cmd.ExecuteReader();

                if (okuyucu.Read())
                {
                    string urunAdi = okuyucu["urun_adi"].ToString();
                    string adet = okuyucu["ToplamAdet"].ToString();
                    return urunAdi + " (" + adet + " Adet)";
                }
                else
                {
                    return "Henüz Satış Yok";
                }
            }
        }


        public string EnIyiMusteriyiBul()
        {
            using (var baglanti = db.GetConnection())
            {
                baglanti.Open();

                // Müşterileri grupla, harcamaları topla, en çok harcayanı en üste al
                string sorgu = @"
            SELECT m.ad_soyad, SUM(s.miktar * u.fiyat) as ToplamHarcama
            FROM satislar s
            JOIN musteriler m ON s.musteri_id = m.id
            JOIN urunler u ON s.urun_id = u.id
            GROUP BY m.ad_soyad
            ORDER BY ToplamHarcama DESC
            LIMIT 1";

                MySqlCommand cmd = new MySqlCommand(sorgu, baglanti);
                MySqlDataReader okuyucu = cmd.ExecuteReader();

                if (okuyucu.Read())
                {
                    string musteriAdi = okuyucu["ad_soyad"].ToString();
                    // Parayı düzgün formatta (TL) göstermek için
                    decimal harcama = Convert.ToDecimal(okuyucu["ToplamHarcama"]);
                    return musteriAdi + " (" + harcama.ToString("C2") + ")";
                }
                else
                {
                    return "Henüz Satış Yok";
                }
            }
        }

    }
}
