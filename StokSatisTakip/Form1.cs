using StokSatis.BLL;
using StokSatis.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokSatisTakip
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            string ad = txtUrunAdi.Text;
            int stok = int.Parse(txtStok.Text);
            decimal fiyat = decimal.Parse(txtFiyat.Text);

            
            ProductManager manager = new ProductManager();
            if (manager.UrunEkleKontrol(ad, fiyat))
            {
               
                ProductDAL dal = new ProductDAL();
                dal.UrunEkle(ad, stok, fiyat);

                MessageBox.Show("Ürün başarıyla kaydedildi!");
            }
            else
            {
                MessageBox.Show("Lütfen bilgileri kontrol edin! (Fiyat 0'dan büyük olmalı)");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListeyiYenile();
        }

        private void ListeyiYenile()
        {
            ProductDAL dal = new ProductDAL();
            
            dgvUrunler.DataSource = dal.UrunleriGetir();
        }

        private void btnStokRaporu_Click(object sender, EventArgs e)
        {
            
            ReportForm raporEkrani = new ReportForm();

           
            raporEkrani.ShowDialog();
        }


        public void YetkileriAyarla(string rol)
        {
            
            if (rol == "Satış Personeli")
            {
                // Satış personeli ürün ekleyemesin veya silemesin
                
                btnKaydet.Visible = false;
                btnSatisFormunuAc.Visible = false; 
            }
            else if (rol == "Depo Görevlisi")
            {
                // Depo görevlisi satış yapamasın
                 btnSatisFormunuAc.Visible = false; 
            }
        }

        private void btnSatisFormunuAc_Click(object sender, EventArgs e)
        {
            
            SalesForm satisEkrani = new SalesForm();

            
            satisEkrani.ShowDialog();

            
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            CustomerForm musteriFormu = new CustomerForm();
            musteriFormu.ShowDialog();
        }
    }
}
