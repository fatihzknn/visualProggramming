namespace dersornek2
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
            this.txt_dosya_yolu = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_oku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dosya Yolu:";
            // 
            // txt_dosya_yolu
            // 
            this.txt_dosya_yolu.Location = new System.Drawing.Point(239, 80);
            this.txt_dosya_yolu.Name = "txt_dosya_yolu";
            this.txt_dosya_yolu.Size = new System.Drawing.Size(323, 23);
            this.txt_dosya_yolu.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 164);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(549, 233);
            this.textBox1.TabIndex = 2;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(550, 26);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 3;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_oku
            // 
            this.btn_oku.Location = new System.Drawing.Point(672, 26);
            this.btn_oku.Name = "btn_oku";
            this.btn_oku.Size = new System.Drawing.Size(75, 23);
            this.btn_oku.TabIndex = 4;
            this.btn_oku.Text = "Oku";
            this.btn_oku.UseVisualStyleBackColor = true;
            this.btn_oku.Click += new System.EventHandler(this.btn_oku_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_oku);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_dosya_yolu);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txt_dosya_yolu;
        private TextBox textBox1;
        private Button btn_kaydet;
        private Button btn_oku;
    }
}