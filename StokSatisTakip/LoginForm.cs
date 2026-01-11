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
    public partial class LoginForm: Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            
            string ad = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            
            UserDAL userDal = new UserDAL();
            string gelenRol = userDal.GirisYap(ad, sifre); 

            
            if (gelenRol != null) 
            {
                MessageBox.Show("Giriş Başarılı! Hoş geldiniz.");

                
                Form1 anaForm = new Form1();

               
                anaForm.YetkileriAyarla(gelenRol);

                anaForm.Show(); 
                this.Hide();    
            }
            else
            {
                
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
            }
        }
    }
}
