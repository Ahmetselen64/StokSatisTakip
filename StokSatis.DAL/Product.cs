using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokSatis.DAL
{
    public class Product
    {
        public int Id { get; set; } 
        public string UrunAdi { get; set; } 
        public int StokAdedi { get; set; } 
        public decimal Fiyat { get; set; } 
    }
}
