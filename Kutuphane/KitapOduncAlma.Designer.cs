namespace Kutuphane
{
    partial class KitapOduncAlma
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
            this.btn_odunc_al = new System.Windows.Forms.Button();
            this.btn_geri_ver = new System.Windows.Forms.Button();
            this.txt_kitap_no = new System.Windows.Forms.TextBox();
            this.txt_ogrenci_no = new System.Windows.Forms.TextBox();
            this.txt_ogrenci_ad = new System.Windows.Forms.TextBox();
            this.txt_ogrenci_soyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_odunc_al
            // 
            this.btn_odunc_al.Location = new System.Drawing.Point(62, 268);
            this.btn_odunc_al.Name = "btn_odunc_al";
            this.btn_odunc_al.Size = new System.Drawing.Size(75, 40);
            this.btn_odunc_al.TabIndex = 0;
            this.btn_odunc_al.Text = "Ödünç Alma";
            this.btn_odunc_al.UseVisualStyleBackColor = true;
            // 
            // btn_geri_ver
            // 
            this.btn_geri_ver.Location = new System.Drawing.Point(225, 268);
            this.btn_geri_ver.Name = "btn_geri_ver";
            this.btn_geri_ver.Size = new System.Drawing.Size(75, 40);
            this.btn_geri_ver.TabIndex = 1;
            this.btn_geri_ver.Text = "Geri Verme";
            this.btn_geri_ver.UseVisualStyleBackColor = true;
            // 
            // txt_kitap_no
            // 
            this.txt_kitap_no.Location = new System.Drawing.Point(214, 35);
            this.txt_kitap_no.Name = "txt_kitap_no";
            this.txt_kitap_no.Size = new System.Drawing.Size(100, 23);
            this.txt_kitap_no.TabIndex = 2;
            // 
            // txt_ogrenci_no
            // 
            this.txt_ogrenci_no.Location = new System.Drawing.Point(214, 85);
            this.txt_ogrenci_no.Name = "txt_ogrenci_no";
            this.txt_ogrenci_no.Size = new System.Drawing.Size(100, 23);
            this.txt_ogrenci_no.TabIndex = 3;
            // 
            // txt_ogrenci_ad
            // 
            this.txt_ogrenci_ad.Location = new System.Drawing.Point(214, 143);
            this.txt_ogrenci_ad.Name = "txt_ogrenci_ad";
            this.txt_ogrenci_ad.Size = new System.Drawing.Size(100, 23);
            this.txt_ogrenci_ad.TabIndex = 4;
            // 
            // txt_ogrenci_soyad
            // 
            this.txt_ogrenci_soyad.Location = new System.Drawing.Point(214, 204);
            this.txt_ogrenci_soyad.Name = "txt_ogrenci_soyad";
            this.txt_ogrenci_soyad.Size = new System.Drawing.Size(100, 23);
            this.txt_ogrenci_soyad.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kitap No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ogrenci No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ogrenci Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ogrenci Soyadı:";
            // 
            // KitapOduncAlma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 352);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ogrenci_soyad);
            this.Controls.Add(this.txt_ogrenci_ad);
            this.Controls.Add(this.txt_ogrenci_no);
            this.Controls.Add(this.txt_kitap_no);
            this.Controls.Add(this.btn_geri_ver);
            this.Controls.Add(this.btn_odunc_al);
            this.Name = "KitapOduncAlma";
            this.Text = "Kitap Odunc Alma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_odunc_al;
        private Button btn_geri_ver;
        private TextBox txt_kitap_no;
        private TextBox txt_ogrenci_no;
        private TextBox txt_ogrenci_ad;
        private TextBox txt_ogrenci_soyad;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}