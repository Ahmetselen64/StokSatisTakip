using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StokSatis.DAL;

namespace StokSatisTakip
{
    public partial class CustomerForm: Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }
        CustomerDAL customerDal = new CustomerDAL();
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            
            cmbMusteriTipi.Items.Add("Perakende");
            cmbMusteriTipi.Items.Add("Toptan");
            cmbMusteriTipi.SelectedIndex = 0; 

            ListeyiYenile();
        }
        
        void ListeyiYenile()
        {
            dgvMusteriler.DataSource = customerDal.MusterileriGetir();
        }

        private void btnMusteriKaydet_Click(object sender, EventArgs e)
        {

            string ad = txtAdSoyad.Text;
            string tel = txtTelefon.Text;
            string adres = txtAdres.Text;
            string tip = cmbMusteriTipi.SelectedItem.ToString();

            
            if (string.IsNullOrEmpty(ad))
            {
                MessageBox.Show("Lütfen müşteri adını giriniz.");
                return;
            }

            customerDal.MusteriEkle(ad, tel, adres, tip);
            MessageBox.Show("Müşteri başarıyla eklendi!");

            
            txtAdSoyad.Clear();
            txtTelefon.Clear();
            txtAdres.Clear();
            ListeyiYenile();


        }
    }
}
