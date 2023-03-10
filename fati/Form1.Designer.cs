namespace fati
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtTipi = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtSayfaS = new System.Windows.Forms.TextBox();
            this.txtKodu = new System.Windows.Forms.TextBox();
            this.txtOduncAlan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblKayitliKitap = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnOdunc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(105, 100);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(100, 23);
            this.txtYazar.TabIndex = 0;
            // 
            // txtTipi
            // 
            this.txtTipi.Location = new System.Drawing.Point(105, 154);
            this.txtTipi.Name = "txtTipi";
            this.txtTipi.Size = new System.Drawing.Size(100, 23);
            this.txtTipi.TabIndex = 1;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(105, 44);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(100, 23);
            this.txtKitapAdi.TabIndex = 2;
            // 
            // txtSayfaS
            // 
            this.txtSayfaS.Location = new System.Drawing.Point(368, 49);
            this.txtSayfaS.Name = "txtSayfaS";
            this.txtSayfaS.Size = new System.Drawing.Size(100, 23);
            this.txtSayfaS.TabIndex = 3;
            // 
            // txtKodu
            // 
            this.txtKodu.Location = new System.Drawing.Point(368, 105);
            this.txtKodu.Name = "txtKodu";
            this.txtKodu.Size = new System.Drawing.Size(100, 23);
            this.txtKodu.TabIndex = 4;
            // 
            // txtOduncAlan
            // 
            this.txtOduncAlan.Location = new System.Drawing.Point(105, 297);
            this.txtOduncAlan.Name = "txtOduncAlan";
            this.txtOduncAlan.Size = new System.Drawing.Size(100, 23);
            this.txtOduncAlan.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kitap Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Yazar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kitap Tipi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sayfa Sayısı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kitap Kodu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ödünç Alan Kişi";
            // 
            // lblKayitliKitap
            // 
            this.lblKayitliKitap.AutoSize = true;
            this.lblKayitliKitap.Location = new System.Drawing.Point(617, 44);
            this.lblKayitliKitap.Name = "lblKayitliKitap";
            this.lblKayitliKitap.Size = new System.Drawing.Size(82, 15);
            this.lblKayitliKitap.TabIndex = 12;
            this.lblKayitliKitap.Text = "Kayıtlı Kitaplar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(380, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(381, 190);
            this.dataGridView1.TabIndex = 13;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(47, 214);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 14;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(185, 214);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 15;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            // 
            // btnOdunc
            // 
            this.btnOdunc.Location = new System.Drawing.Point(105, 363);
            this.btnOdunc.Name = "btnOdunc";
            this.btnOdunc.Size = new System.Drawing.Size(75, 23);
            this.btnOdunc.TabIndex = 16;
            this.btnOdunc.Text = "Ödünç Ver";
            this.btnOdunc.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOdunc);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblKayitliKitap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOduncAlan);
            this.Controls.Add(this.txtKodu);
            this.Controls.Add(this.txtSayfaS);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.txtTipi);
            this.Controls.Add(this.txtYazar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtYazar;
        private TextBox txtTipi;
        private TextBox txtKitapAdi;
        private TextBox txtSayfaS;
        private TextBox txtKodu;
        private TextBox txtOduncAlan;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblKayitliKitap;
        private DataGridView dataGridView1;
        private Button btnKaydet;
        private Button btnAra;
        private Button btnOdunc;
    }
}