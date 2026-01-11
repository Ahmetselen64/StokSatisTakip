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
    public partial class ReportForm: Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            ProductDAL dal = new ProductDAL();
            
            dgvKritikRapor.DataSource = dal.KritikStoklariGetir();

            
            dgvKritikRapor.DefaultCellStyle.BackColor = Color.LightCoral;
        }

        private void btnRaporla_Click(object sender, EventArgs e)
        {
            ReportDAL raporDal = new ReportDAL();
            DataTable tablo = raporDal.TumSatislariGetir();

            
            dgvRapor.DataSource = tablo;

            
            decimal toplamCiro = 0;
            foreach (DataRow satir in tablo.Rows)
            {
                
                toplamCiro += Convert.ToDecimal(satir["ToplamTutar"]);
            }

            lblToplamCiro.Text = toplamCiro.ToString("C2"); 
        }
    }
}
