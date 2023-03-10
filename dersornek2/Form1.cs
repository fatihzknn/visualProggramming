namespace dersornek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            File.WriteAllText("C:/Users/fatih/Desktop/visual_programming/dosyam.txt", textBox1.Text);
        }

        private void btn_oku_Click(object sender, EventArgs e)
        {
            textBox1.Text = File.ReadAllText(txt_dosya_yolu.Text);
        }
    }
}