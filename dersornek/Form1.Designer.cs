namespace dersornek
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_plaka_kodu = new System.Windows.Forms.TextBox();
            this.txt_sehir_adi = new System.Windows.Forms.TextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_ara = new System.Windows.Forms.Button();
            this.lbl_sayac = new System.Windows.Forms.Label();
            this.btn_sil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaka Kodu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(516, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şehir Adı:";
            // 
            // txt_plaka_kodu
            // 
            this.txt_plaka_kodu.Location = new System.Drawing.Point(245, 104);
            this.txt_plaka_kodu.Name = "txt_plaka_kodu";
            this.txt_plaka_kodu.Size = new System.Drawing.Size(100, 23);
            this.txt_plaka_kodu.TabIndex = 2;
            // 
            // txt_sehir_adi
            // 
            this.txt_sehir_adi.Location = new System.Drawing.Point(579, 101);
            this.txt_sehir_adi.Name = "txt_sehir_adi";
            this.txt_sehir_adi.Size = new System.Drawing.Size(100, 23);
            this.txt_sehir_adi.TabIndex = 3;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(361, 210);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 4;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(540, 210);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(75, 23);
            this.btn_ara.TabIndex = 5;
            this.btn_ara.Text = "Ara";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // lbl_sayac
            // 
            this.lbl_sayac.AutoSize = true;
            this.lbl_sayac.Location = new System.Drawing.Point(249, 21);
            this.lbl_sayac.Name = "lbl_sayac";
            this.lbl_sayac.Size = new System.Drawing.Size(40, 15);
            this.lbl_sayac.TabIndex = 6;
            this.lbl_sayac.Text = "Sayaç:";
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(684, 210);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 7;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.lbl_sayac);
            this.Controls.Add(this.btn_ara);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.txt_sehir_adi);
            this.Controls.Add(this.txt_plaka_kodu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_plaka_kodu;
        private TextBox txt_sehir_adi;
        private Button btn_kaydet;
        private Button btn_ara;
        private Label lbl_sayac;
        private Button btn_sil;
    }
}