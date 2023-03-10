namespace Kutuphane
{
    partial class Kutuphane
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Kitap_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yazar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sayfa_sayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alan_kisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_kitap_al_ver = new System.Windows.Forms.Button();
            this.btn_kayit_arama = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kitap_adi,
            this.Yazar,
            this.Tur,
            this.Sayfa_sayisi,
            this.Alan_kisi});
            this.dataGridView1.Location = new System.Drawing.Point(12, 310);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(543, 168);
            this.dataGridView1.TabIndex = 0;
            // 
            // Kitap_adi
            // 
            this.Kitap_adi.HeaderText = "Kitap Adı";
            this.Kitap_adi.Name = "Kitap_adi";
            // 
            // Yazar
            // 
            this.Yazar.HeaderText = "Yazar";
            this.Yazar.Name = "Yazar";
            // 
            // Tur
            // 
            this.Tur.HeaderText = "Türü";
            this.Tur.Name = "Tur";
            // 
            // Sayfa_sayisi
            // 
            this.Sayfa_sayisi.HeaderText = "Sayfa Sayısı";
            this.Sayfa_sayisi.Name = "Sayfa_sayisi";
            // 
            // Alan_kisi
            // 
            this.Alan_kisi.HeaderText = "Ödünç Alan Kişi";
            this.Alan_kisi.Name = "Alan_kisi";
            // 
            // btn_kitap_al_ver
            // 
            this.btn_kitap_al_ver.Location = new System.Drawing.Point(134, 195);
            this.btn_kitap_al_ver.Name = "btn_kitap_al_ver";
            this.btn_kitap_al_ver.Size = new System.Drawing.Size(316, 102);
            this.btn_kitap_al_ver.TabIndex = 11;
            this.btn_kitap_al_ver.Text = "Kitap Ödünç Alma ve Geri Verme İşlemleri İçin Tıklayınız";
            this.btn_kitap_al_ver.UseVisualStyleBackColor = true;
            this.btn_kitap_al_ver.Click += new System.EventHandler(this.btn_kitap_al_ver_Click);
            // 
            // btn_kayit_arama
            // 
            this.btn_kayit_arama.Location = new System.Drawing.Point(134, 66);
            this.btn_kayit_arama.Name = "btn_kayit_arama";
            this.btn_kayit_arama.Size = new System.Drawing.Size(316, 108);
            this.btn_kayit_arama.TabIndex = 12;
            this.btn_kayit_arama.Text = "Kitap Kayıt ve Arama İşlemleri İçin Tıklayınız";
            this.btn_kayit_arama.UseVisualStyleBackColor = true;
            this.btn_kayit_arama.Click += new System.EventHandler(this.btn_kayit_arama_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(80, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "KÜTÜPHANEMİZE HOŞGELDİNİZ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Kutuphane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(574, 490);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_kayit_arama);
            this.Controls.Add(this.btn_kitap_al_ver);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Kutuphane";
            this.Text = "Kütüphane";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Kitap_adi;
        private DataGridViewTextBoxColumn Yazar;
        private DataGridViewTextBoxColumn Tur;
        private DataGridViewTextBoxColumn Sayfa_sayisi;
        private DataGridViewTextBoxColumn Alan_kisi;
        private Button btn_kitap_al_ver;
        private Button btn_kayit_arama;
        private Label label1;
    }
}