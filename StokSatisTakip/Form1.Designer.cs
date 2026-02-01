namespace StokSatisTakip
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.btnStokRaporu = new System.Windows.Forms.Button();
            this.btnSatisFormunuAc = new System.Windows.Forms.Button();
            this.btnMusteriler = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(561, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(700, 36);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(100, 22);
            this.txtUrunAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(583, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fiyat";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(700, 83);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 22);
            this.txtFiyat.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(585, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stok";
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(700, 137);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(100, 22);
            this.txtStok.TabIndex = 5;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(530, 212);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(112, 78);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Ürünü Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Location = new System.Drawing.Point(12, 12);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.RowHeadersWidth = 51;
            this.dgvUrunler.RowTemplate.Height = 24;
            this.dgvUrunler.Size = new System.Drawing.Size(448, 523);
            this.dgvUrunler.TabIndex = 7;
            this.dgvUrunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrunler_CellClick);
            // 
            // btnStokRaporu
            // 
            this.btnStokRaporu.BackColor = System.Drawing.Color.Gray;
            this.btnStokRaporu.Location = new System.Drawing.Point(997, 36);
            this.btnStokRaporu.Name = "btnStokRaporu";
            this.btnStokRaporu.Size = new System.Drawing.Size(117, 93);
            this.btnStokRaporu.TabIndex = 8;
            this.btnStokRaporu.Text = "Kritik Stok Raporu";
            this.btnStokRaporu.UseVisualStyleBackColor = false;
            this.btnStokRaporu.Click += new System.EventHandler(this.btnStokRaporu_Click);
            // 
            // btnSatisFormunuAc
            // 
            this.btnSatisFormunuAc.BackColor = System.Drawing.Color.Gray;
            this.btnSatisFormunuAc.Location = new System.Drawing.Point(997, 176);
            this.btnSatisFormunuAc.Name = "btnSatisFormunuAc";
            this.btnSatisFormunuAc.Size = new System.Drawing.Size(117, 93);
            this.btnSatisFormunuAc.TabIndex = 9;
            this.btnSatisFormunuAc.Text = "Satış Ekranına Git";
            this.btnSatisFormunuAc.UseVisualStyleBackColor = false;
            this.btnSatisFormunuAc.Click += new System.EventHandler(this.btnSatisFormunuAc_Click);
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.BackColor = System.Drawing.Color.Gray;
            this.btnMusteriler.Location = new System.Drawing.Point(997, 316);
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.Size = new System.Drawing.Size(117, 93);
            this.btnMusteriler.TabIndex = 10;
            this.btnMusteriler.Text = "Müşteriler";
            this.btnMusteriler.UseVisualStyleBackColor = false;
            this.btnMusteriler.Click += new System.EventHandler(this.btnMusteriler_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(688, 212);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(112, 78);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Ürünü Eksilt";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(618, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 78);
            this.button1.TabIndex = 12;
            this.button1.Text = "Ürünü Güncelle";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1272, 564);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnMusteriler);
            this.Controls.Add(this.btnSatisFormunuAc);
            this.Controls.Add(this.btnStokRaporu);
            this.Controls.Add(this.dgvUrunler);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.Button btnStokRaporu;
        private System.Windows.Forms.Button btnSatisFormunuAc;
        private System.Windows.Forms.Button btnMusteriler;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button button1;
    }
}

