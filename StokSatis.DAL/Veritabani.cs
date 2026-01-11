using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StokSatis.DAL
{
    public class Veritabani
    {
        
        
        public string BaglantiCumlesi = "Server=172.21.54.253;Database=26_132430070;User ID=26_132430070;Password=İnif123.;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(BaglantiCumlesi);
        }
    }
}

