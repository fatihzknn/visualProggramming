namespace Kutuphanebasic
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_ara = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_kitap_ad = new System.Windows.Forms.Label();
            this.lbl_kitap_no = new System.Windows.Forms.Label();
            this.txt_tur = new System.Windows.Forms.TextBox();
            this.txt_sayfa = new System.Windows.Forms.TextBox();
            this.txt_yazar = new System.Windows.Forms.TextBox();
            this.txt_kitap_ad = new System.Windows.Forms.TextBox();
            this.txt_kitap_no = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ogrenci_soyad = new System.Windows.Forms.TextBox();
            this.txt_ogrenci_ad = new System.Windows.Forms.TextBox();
            this.txt_ogrenci_no = new System.Windows.Forms.TextBox();
            this.btn_geri_ver = new System.Windows.Forms.Button();
            this.btn_odunc_al = new System.Windows.Forms.Button();
            this.lbl_mevcut_kitap = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kitapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitapBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(206, 334);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(75, 40);
            this.btn_ara.TabIndex = 3;
            this.btn_ara.Text = "Kitabı Ara";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(43, 334);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 40);
            this.btn_kaydet.TabIndex = 2;
            this.btn_kaydet.Text = "Kitabı Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Türü:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Sayfa Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Yazarı:";
            // 
            // lbl_kitap_ad
            // 
            this.lbl_kitap_ad.AutoSize = true;
            this.lbl_kitap_ad.Location = new System.Drawing.Point(30, 113);
            this.lbl_kitap_ad.Name = "lbl_kitap_ad";
            this.lbl_kitap_ad.Size = new System.Drawing.Size(58, 15);
            this.lbl_kitap_ad.TabIndex = 18;
            this.lbl_kitap_ad.Text = "Kitap Adı:";
            // 
            // lbl_kitap_no
            // 
            this.lbl_kitap_no.AutoSize = true;
            this.lbl_kitap_no.Location = new System.Drawing.Point(317, 35);
            this.lbl_kitap_no.Name = "lbl_kitap_no";
            this.lbl_kitap_no.Size = new System.Drawing.Size(56, 15);
            this.lbl_kitap_no.TabIndex = 17;
            this.lbl_kitap_no.Text = "Kitap No:";
            // 
            // txt_tur
            // 
            this.txt_tur.Location = new System.Drawing.Point(181, 249);
            this.txt_tur.Name = "txt_tur";
            this.txt_tur.Size = new System.Drawing.Size(100, 23);
            this.txt_tur.TabIndex = 16;
            // 
            // txt_sayfa
            // 
            this.txt_sayfa.Location = new System.Drawing.Point(181, 198);
            this.txt_sayfa.Name = "txt_sayfa";
            this.txt_sayfa.Size = new System.Drawing.Size(100, 23);
            this.txt_sayfa.TabIndex = 15;
            // 
            // txt_yazar
            // 
            this.txt_yazar.Location = new System.Drawing.Point(181, 147);
            this.txt_yazar.Name = "txt_yazar";
            this.txt_yazar.Size = new System.Drawing.Size(100, 23);
            this.txt_yazar.TabIndex = 14;
            // 
            // txt_kitap_ad
            // 
            this.txt_kitap_ad.Location = new System.Drawing.Point(181, 105);
            this.txt_kitap_ad.Name = "txt_kitap_ad";
            this.txt_kitap_ad.Size = new System.Drawing.Size(100, 23);
            this.txt_kitap_ad.TabIndex = 13;
            // 
            // txt_kitap_no
            // 
            this.txt_kitap_no.Location = new System.Drawing.Point(379, 32);
            this.txt_kitap_no.Name = "txt_kitap_no";
            this.txt_kitap_no.Size = new System.Drawing.Size(100, 23);
            this.txt_kitap_no.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "Ogrenci Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Ogrenci Adı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(445, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "Ogrenci No:";
            // 
            // txt_ogrenci_soyad
            // 
            this.txt_ogrenci_soyad.Location = new System.Drawing.Point(597, 228);
            this.txt_ogrenci_soyad.Name = "txt_ogrenci_soyad";
            this.txt_ogrenci_soyad.Size = new System.Drawing.Size(100, 23);
            this.txt_ogrenci_soyad.TabIndex = 27;
            // 
            // txt_ogrenci_ad
            // 
            this.txt_ogrenci_ad.Location = new System.Drawing.Point(597, 167);
            this.txt_ogrenci_ad.Name = "txt_ogrenci_ad";
            this.txt_ogrenci_ad.Size = new System.Drawing.Size(100, 23);
            this.txt_ogrenci_ad.TabIndex = 26;
            // 
            // txt_ogrenci_no
            // 
            this.txt_ogrenci_no.Location = new System.Drawing.Point(597, 109);
            this.txt_ogrenci_no.Name = "txt_ogrenci_no";
            this.txt_ogrenci_no.Size = new System.Drawing.Size(100, 23);
            this.txt_ogrenci_no.TabIndex = 25;
            // 
            // btn_geri_ver
            // 
            this.btn_geri_ver.Location = new System.Drawing.Point(613, 334);
            this.btn_geri_ver.Name = "btn_geri_ver";
            this.btn_geri_ver.Size = new System.Drawing.Size(75, 40);
            this.btn_geri_ver.TabIndex = 23;
            this.btn_geri_ver.Text = "Geri Verme";
            this.btn_geri_ver.UseVisualStyleBackColor = true;
            // 
            // btn_odunc_al
            // 
            this.btn_odunc_al.Location = new System.Drawing.Point(450, 334);
            this.btn_odunc_al.Name = "btn_odunc_al";
            this.btn_odunc_al.Size = new System.Drawing.Size(75, 40);
            this.btn_odunc_al.TabIndex = 22;
            this.btn_odunc_al.Text = "Ödünç Alma";
            this.btn_odunc_al.UseVisualStyleBackColor = true;
            this.btn_odunc_al.Click += new System.EventHandler(this.btn_odunc_al_Click);
            // 
            // lbl_mevcut_kitap
            // 
            this.lbl_mevcut_kitap.AutoSize = true;
            this.lbl_mevcut_kitap.Location = new System.Drawing.Point(505, 250);
            this.lbl_mevcut_kitap.Name = "lbl_mevcut_kitap";
            this.lbl_mevcut_kitap.Size = new System.Drawing.Size(0, 15);
            this.lbl_mevcut_kitap.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 15);
            this.label8.TabIndex = 32;
            this.label8.Text = "Kütüphanedeki Mevcut Kitap Sayısı: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(43, 421);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(752, 168);
            this.dataGridView1.TabIndex = 34;
            // 
            // kitapBindingSource
            // 
            this.kitapBindingSource.DataSource = typeof(Kutuphanebasic.Kitap);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(234, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 15);
            this.label9.TabIndex = 35;
            // 
            // ogrenciBindingSource
            // 
            this.ogrenciBindingSource.DataSource = typeof(Kutuphanebasic.Ogrenci);
            // 
            // kitapBindingSource1
            // 
            this.kitapBindingSource1.DataSource = typeof(Kutuphanebasic.Kitap);
            // 
            // ogrenciBindingSource1
            // 
            this.ogrenciBindingSource1.DataSource = typeof(Kutuphanebasic.Ogrenci);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(807, 613);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_mevcut_kitap);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_ogrenci_soyad);
            this.Controls.Add(this.txt_ogrenci_ad);
            this.Controls.Add(this.txt_ogrenci_no);
            this.Controls.Add(this.btn_geri_ver);
            this.Controls.Add(this.btn_odunc_al);
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
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_ara;
        private Button btn_kaydet;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lbl_kitap_ad;
        private Label lbl_kitap_no;
        private TextBox txt_tur;
        private TextBox txt_sayfa;
        private TextBox txt_yazar;
        private TextBox txt_kitap_ad;
        private TextBox txt_kitap_no;
        private Label label1;
        private Label label2;
        private Label label6;
        private TextBox txt_ogrenci_soyad;
        private TextBox txt_ogrenci_ad;
        private TextBox txt_ogrenci_no;
        private Button btn_geri_ver;
        private Button btn_odunc_al;
        private Label lbl_mevcut_kitap;
        private Label label8;
        private DataGridView dataGridView1;
        private Label label9;
        private BindingSource ogrenciBindingSource;
        private BindingSource kitapBindingSource;
        private BindingSource ogrenciBindingSource1;
        private BindingSource kitapBindingSource1;
    }
}