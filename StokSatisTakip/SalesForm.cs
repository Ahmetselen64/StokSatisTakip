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
using MySql.Data.MySqlClient;

namespace StokSatisTakip
{
    public partial class SalesForm: Form
    {
        public SalesForm()
        {
            InitializeComponent();
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            // 1. Önce Formdan Verileri Alalım (Değişkenleri burada TEK SEFER tanımlıyoruz)
            int secilenUrunId = Convert.ToInt32(cmbUrunler.SelectedValue);
            int satilacakMiktar = Convert.ToInt32(txtMiktar.Text);
            int secilenMusteriId = Convert.ToInt32(cmbMusteriler.SelectedValue);

            ProductDAL dal = new ProductDAL();

            // 2. STOK KONTROLÜ (Hocanın istediği kısım)
            // Veritabanından o ürünün güncel stok adedini soruyoruz
            int mevcutStok = dal.StokAdediOgren(secilenUrunId);

            if (mevcutStok < satilacakMiktar)
            {
                MessageBox.Show("Yetersiz Stok! Depoda sadece " + mevcutStok + " adet var. Satış yapılamaz.");
                return; // İşlemi burada kesip bitiriyoruz, aşağıya inmez.
            }

            // 3. SATIŞ İŞLEMİ (Eğer stok varsa burası çalışır)
            try
            {
                dal.SatisKaydet(secilenUrunId, satilacakMiktar, secilenMusteriId);
                MessageBox.Show("Satış başarıyla müşteriye işlendi!");
                this.Close(); // İşlem bitince pencereyi kapat
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            ProductDAL dal = new ProductDAL();
            DataTable urunler = dal.TumUrunleriGetir();

            
            cmbUrunler.DataSource = urunler;
            cmbUrunler.DisplayMember = "urun_adi"; 
            cmbUrunler.ValueMember = "id";         
                                                   
            CustomerDAL customerDal = new CustomerDAL(); 
            cmbMusteriler.DataSource = customerDal.MusterileriGetir();
            cmbMusteriler.DisplayMember = "ad_soyad"; 
            cmbMusteriler.ValueMember = "id";         
        }
    }
}
