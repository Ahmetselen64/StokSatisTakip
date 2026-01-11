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




    }
}
