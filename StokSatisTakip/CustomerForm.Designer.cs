namespace StokSatisTakip
{
    partial class CustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMusteriTipi = new System.Windows.Forms.ComboBox();
            this.btnMusteriKaydet = new System.Windows.Forms.Button();
            this.dgvMusteriler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(850, 50);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtAdSoyad.TabIndex = 0;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(850, 114);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 22);
            this.txtTelefon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(696, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(716, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "telefon";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(850, 178);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(100, 22);
            this.txtAdres.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(716, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "adres";
            // 
            // cmbMusteriTipi
            // 
            this.cmbMusteriTipi.FormattingEnabled = true;
            this.cmbMusteriTipi.Location = new System.Drawing.Point(1046, 114);
            this.cmbMusteriTipi.Name = "cmbMusteriTipi";
            this.cmbMusteriTipi.Size = new System.Drawing.Size(121, 24);
            this.cmbMusteriTipi.TabIndex = 6;
            // 
            // btnMusteriKaydet
            // 
            this.btnMusteriKaydet.BackColor = System.Drawing.Color.Lime;
            this.btnMusteriKaydet.Location = new System.Drawing.Point(850, 272);
            this.btnMusteriKaydet.Name = "btnMusteriKaydet";
            this.btnMusteriKaydet.Size = new System.Drawing.Size(92, 97);
            this.btnMusteriKaydet.TabIndex = 7;
            this.btnMusteriKaydet.Text = "Kaydet";
            this.btnMusteriKaydet.UseVisualStyleBackColor = false;
            this.btnMusteriKaydet.Click += new System.EventHandler(this.btnMusteriKaydet_Click);
            // 
            // dgvMusteriler
            // 
            this.dgvMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriler.Location = new System.Drawing.Point(12, 12);
            this.dgvMusteriler.Name = "dgvMusteriler";
            this.dgvMusteriler.RowHeadersWidth = 51;
            this.dgvMusteriler.RowTemplate.Height = 24;
            this.dgvMusteriler.Size = new System.Drawing.Size(544, 412);
            this.dgvMusteriler.TabIndex = 8;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1219, 450);
            this.Controls.Add(this.dgvMusteriler);
            this.Controls.Add(this.btnMusteriKaydet);
            this.Controls.Add(this.cmbMusteriTipi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtAdSoyad);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMusteriTipi;
        private System.Windows.Forms.Button btnMusteriKaydet;
        private System.Windows.Forms.DataGridView dgvMusteriler;
    }
}