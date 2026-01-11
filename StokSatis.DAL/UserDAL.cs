using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StokSatis.DAL
{
    public class UserDAL
    {

        
        Veritabani veritabani = new Veritabani();

        public string GirisYap(string ad, string sifre)
        {
            
            using (var baglanti = veritabani.GetConnection())
            {
                try
                {
                    baglanti.Open();

                    
                    string sorgu = "SELECT rol FROM kullanicilar WHERE kullanici_adi=@ad AND sifre=@sifre";

                    MySqlCommand cmd = new MySqlCommand(sorgu, baglanti);
                    cmd.Parameters.AddWithValue("@ad", ad);
                    cmd.Parameters.AddWithValue("@sifre", sifre);

                    
                    object sonuc = cmd.ExecuteScalar();

                    
                    return sonuc != null ? sonuc.ToString() : null;
                }
                catch (Exception ex)
                {
                    
                    throw new Exception("Giriş yapılırken hata oluştu: " + ex.Message);
                }
            }
        }
    }
}
