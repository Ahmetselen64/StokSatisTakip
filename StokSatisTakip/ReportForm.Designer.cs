namespace StokSatisTakip
{
    partial class ReportForm
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
            this.dgvKritikRapor = new System.Windows.Forms.DataGridView();
            this.dgvRapor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToplamCiro = new System.Windows.Forms.Label();
            this.btnRaporla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEnCokSatan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEnIyiMusteri = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKritikRapor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKritikRapor
            // 
            this.dgvKritikRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKritikRapor.Location = new System.Drawing.Point(129, 253);
            this.dgvKritikRapor.Name = "dgvKritikRapor";
            this.dgvKritikRapor.RowHeadersWidth = 51;
            this.dgvKritikRapor.RowTemplate.Height = 24;
            this.dgvKritikRapor.Size = new System.Drawing.Size(450, 228);
            this.dgvKritikRapor.TabIndex = 0;
            // 
            // dgvRapor
            // 
            this.dgvRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRapor.Location = new System.Drawing.Point(129, 3);
            this.dgvRapor.Name = "dgvRapor";
            this.dgvRapor.RowHeadersWidth = 51;
            this.dgvRapor.RowTemplate.Height = 24;
            this.dgvRapor.Size = new System.Drawing.Size(450, 228);
            this.dgvRapor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(956, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Toplam Ciro";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblToplamCiro
            // 
            this.lblToplamCiro.AutoSize = true;
            this.lblToplamCiro.BackColor = System.Drawing.Color.Cyan;
            this.lblToplamCiro.ForeColor = System.Drawing.Color.Red;
            this.lblToplamCiro.Location = new System.Drawing.Point(1091, 483);
            this.lblToplamCiro.Name = "lblToplamCiro";
            this.lblToplamCiro.Size = new System.Drawing.Size(50, 16);
            this.lblToplamCiro.TabIndex = 3;
            this.lblToplamCiro.Text = "0.00 TL";
            // 
            // btnRaporla
            // 
            this.btnRaporla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRaporla.Location = new System.Drawing.Point(1050, 191);
            this.btnRaporla.Name = "btnRaporla";
            this.btnRaporla.Size = new System.Drawing.Size(138, 138);
            this.btnRaporla.TabIndex = 4;
            this.btnRaporla.Text = "Satışları Listele";
            this.btnRaporla.UseVisualStyleBackColor = false;
            this.btnRaporla.Click += new System.EventHandler(this.btnRaporla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Satışlar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kritik stok";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEnCokSatan);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(733, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 125);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "En Çok Satan";
            // 
            // lblEnCokSatan
            // 
            this.lblEnCokSatan.AutoSize = true;
            this.lblEnCokSatan.ForeColor = System.Drawing.Color.Black;
            this.lblEnCokSatan.Location = new System.Drawing.Point(23, 36);
            this.lblEnCokSatan.Name = "lblEnCokSatan";
            this.lblEnCokSatan.Size = new System.Drawing.Size(16, 16);
            this.lblEnCokSatan.TabIndex = 0;
            this.lblEnCokSatan.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(685, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "ENİYİ MÜŞTERİ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblEnIyiMusteri
            // 
            this.lblEnIyiMusteri.AutoSize = true;
            this.lblEnIyiMusteri.Location = new System.Drawing.Point(882, 313);
            this.lblEnIyiMusteri.Name = "lblEnIyiMusteri";
            this.lblEnIyiMusteri.Size = new System.Drawing.Size(16, 16);
            this.lblEnIyiMusteri.TabIndex = 9;
            this.lblEnIyiMusteri.Text = "...";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1299, 552);
            this.Controls.Add(this.lblEnIyiMusteri);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRaporla);
            this.Controls.Add(this.lblToplamCiro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRapor);
            this.Controls.Add(this.dgvKritikRapor);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKritikRapor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKritikRapor;
        private System.Windows.Forms.DataGridView dgvRapor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToplamCiro;
        private System.Windows.Forms.Button btnRaporla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEnCokSatan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEnIyiMusteri;
    }
}