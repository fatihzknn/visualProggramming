namespace Kutuphane
{
    public partial class Kutuphane : Form
    {
        public List<Kitap> kitap = new List<Kitap>();
        public List<Ogrenci> ogrenci = new List<Ogrenci>();
        public Kutuphane()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void btn_kayit_arama_Click(object sender, EventArgs e)
        {
            var kitapKayitArama = new KitapKayıtArama
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            kitapKayitArama.StartPosition = FormStartPosition.CenterParent;
            kitapKayitArama.ShowDialog(this);
        }

        private void btn_kitap_al_ver_Click(object sender, EventArgs e)
        {
            var kitapOduncAlma = new KitapOduncAlma
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            kitapOduncAlma.StartPosition = FormStartPosition.CenterParent;
            kitapOduncAlma.ShowDialog(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}