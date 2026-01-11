using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokSatis.BLL
{
    public class ProductManager
    {
        public bool UrunEkleKontrol(string ad, decimal fiyat)
        {
            
            if (string.IsNullOrEmpty(ad)) return false; 
            if (fiyat <= 0) return false;  

            return true; 
        }


        public bool StokUyariVerilmeliMi(int stok)
        {
            
            return stok < 5;
        }
    }
}
