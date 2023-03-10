namespace dersornek
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> sehirListesi = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (!sehirListesi.ContainsKey(txt_plaka_kodu.Text))
            {
                sehirListesi.Add(txt_plaka_kodu.Text, txt_sehir_adi.Text);
                lbl_sayac.Text = "" + sehirListesi.Count();
            }
            else
            {
                sehirListesi[txt_plaka_kodu.Text] = txt_sehir_adi.Text;
            }
           
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            if(sehirListesi.ContainsKey(txt_plaka_kodu.Text))
            {
                MessageBox.Show(txt_plaka_kodu.Text + "id'li şehrin adı: " + sehirListesi[txt_plaka_kodu.Text]);
            }
            else
            {
                MessageBox.Show("Böyle bir kayıt bulunamadı");
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            sehirListesi.Remove(txt_plaka_kodu.Text);
            lbl_sayac.Text = "" + (sehirListesi.Count()-1);
        }
    }
}