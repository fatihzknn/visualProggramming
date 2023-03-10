namespace Kutuphane
{
    partial class KitapKayıtArama
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
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_ara = new System.Windows.Forms.Button();
            this.txt_kitap_no = new System.Windows.Forms.TextBox();
            this.txt_kitap_ad = new System.Windows.Forms.TextBox();
            this.txt_yazar = new System.Windows.Forms.TextBox();
            this.txt_sayfa = new System.Windows.Forms.TextBox();
            this.txt_tur = new System.Windows.Forms.TextBox();
            this.lbl_kitap_no = new System.Windows.Forms.Label();
            this.lbl_kitap_ad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_mevcut_kitap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(56, 272);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 40);
            this.btn_kaydet.TabIndex = 0;
            this.btn_kaydet.Text = "Kitabı Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(219, 272);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(75, 40);
            this.btn_ara.TabIndex = 1;
            this.btn_ara.Text = "Kitabı Ara";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // txt_kitap_no
            // 
            this.txt_kitap_no.Location = new System.Drawing.Point(219, 28);
            this.txt_kitap_no.Name = "txt_kitap_no";
            this.txt_kitap_no.Size = new System.Drawing.Size(100, 23);
            this.txt_kitap_no.TabIndex = 2;
            // 
            // txt_kitap_ad
            // 
            this.txt_kitap_ad.Location = new System.Drawing.Point(219, 74);
            this.txt_kitap_ad.Name = "txt_kitap_ad";
            this.txt_kitap_ad.Size = new System.Drawing.Size(100, 23);
            this.txt_kitap_ad.TabIndex = 3;
            // 
            // txt_yazar
            // 
            this.txt_yazar.Location = new System.Drawing.Point(219, 116);
            this.txt_yazar.Name = "txt_yazar";
            this.txt_yazar.Size = new System.Drawing.Size(100, 23);
            this.txt_yazar.TabIndex = 4;
            // 
            // txt_sayfa
            // 
            this.txt_sayfa.Location = new System.Drawing.Point(219, 167);
            this.txt_sayfa.Name = "txt_sayfa";
            this.txt_sayfa.Size = new System.Drawing.Size(100, 23);
            this.txt_sayfa.TabIndex = 5;
            // 
            // txt_tur
            // 
            this.txt_tur.Location = new System.Drawing.Point(219, 218);
            this.txt_tur.Name = "txt_tur";
            this.txt_tur.Size = new System.Drawing.Size(100, 23);
            this.txt_tur.TabIndex = 6;
            // 
            // lbl_kitap_no
            // 
            this.lbl_kitap_no.AutoSize = true;
            this.lbl_kitap_no.Location = new System.Drawing.Point(68, 36);
            this.lbl_kitap_no.Name = "lbl_kitap_no";
            this.lbl_kitap_no.Size = new System.Drawing.Size(56, 15);
            this.lbl_kitap_no.TabIndex = 7;
            this.lbl_kitap_no.Text = "Kitap No:";
            // 
            // lbl_kitap_ad
            // 
            this.lbl_kitap_ad.AutoSize = true;
            this.lbl_kitap_ad.Location = new System.Drawing.Point(68, 82);
            this.lbl_kitap_ad.Name = "lbl_kitap_ad";
            this.lbl_kitap_ad.Size = new System.Drawing.Size(58, 15);
            this.lbl_kitap_ad.TabIndex = 8;
            this.lbl_kitap_ad.Text = "Kitap Adı:";
            this.lbl_kitap_ad.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Yazarı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sayfa Sayısı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Türü:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kütüphanedeki Mevcut Kitap Sayısı: ";
            // 
            // lbl_mevcut_kitap
            // 
            this.lbl_mevcut_kitap.AutoSize = true;
            this.lbl_mevcut_kitap.Location = new System.Drawing.Point(340, 9);
            this.lbl_mevcut_kitap.Name = "lbl_mevcut_kitap";
            this.lbl_mevcut_kitap.Size = new System.Drawing.Size(0, 15);
            this.lbl_mevcut_kitap.TabIndex = 13;
            // 
            // KitapKayıtArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 340);
            this.Controls.Add(this.lbl_mevcut_kitap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_kitap_ad);
            this.Controls.Add(this.lbl_kitap_no);
            this.Controls.Add(this.txt_tur);
            this.Controls.Add(this.txt_sayfa);
            this.Controls.Add(this.txt_yazar);
            this.Controls.Add(this.txt_kitap_ad);
            this.Controls.Add(this.txt_kitap_no);
            this.Controls.Add(this.btn_ara);
            this.Controls.Add(this.btn_kaydet);
            this.Name = "KitapKayıtArama";
            this.Text = "Kayıt ve Arama";
            this.Load += new System.EventHandler(this.KitapKayıtArama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_kaydet;
        private Button btn_ara;
        private TextBox txt_kitap_no;
        private TextBox txt_kitap_ad;
        private TextBox txt_yazar;
        private TextBox txt_sayfa;
        private TextBox txt_tur;
        private Label lbl_kitap_no;
        private Label lbl_kitap_ad;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label1;
        private Label lbl_mevcut_kitap;
    }
}