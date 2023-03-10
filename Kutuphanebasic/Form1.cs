using System.Data;
using System.Drawing;

namespace Kutuphanebasic
{
    public partial class Form1 : Form
    {
        public List<Kitap> kitap = new List<Kitap>();
        public List<Ogrenci> ogrenci = new List<Ogrenci>();
        public Form1()
        {
            InitializeComponent();
        }
        //static int indeksbul(int indeks)
        //{
        //    List<Kitap> kitapp = new List<Kitap>();
        //    int indeks = 0;
            
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "Kitap No";
            dataGridView1.Columns[1].Name = "Kitap Adı";
            dataGridView1.Columns[2].Name = "Yazar";
            dataGridView1.Columns[3].Name = "Sayfa Sayısı";
            dataGridView1.Columns[4].Name = "Tür";
            dataGridView1.Columns[5].Name = "Ogrenci No";
            dataGridView1.Columns[6].Name = "Ogrenci Adı";
            dataGridView1.Columns[7].Name = "Ogrenci Soyadı";
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (txt_kitap_no.Text == "" || txt_kitap_ad.Text == "" || txt_sayfa.Text == "" || txt_yazar.Text == "" || txt_tur.Text == "")
            {
                MessageBox.Show("Kitap ile ilgili tüm bilgilerin girilmesi gereklidir.");
            }
            else
            {
                Kitap tmpkitap = new Kitap();
                tmpkitap.Turu = txt_tur.Text;
                tmpkitap.KitapNo = txt_kitap_no.Text;
                tmpkitap.Yazar = txt_yazar.Text;
                tmpkitap.KitapAdi = txt_kitap_ad.Text;
                tmpkitap.SayfaSayisi = (txt_sayfa.Text);
                if (kitap.FindIndex(s => s.KitapNo == tmpkitap.KitapNo) == -1)
                {
                    kitap.Add(tmpkitap);
                    label9.Text = kitap.Count.ToString();
                    MessageBox.Show("Kitap Başarıyla Sisteme Kayıt Edilmiştir");
                }

                else
                    MessageBox.Show("Girdiğiniz ID de zaten kayıt bulunmaktadır");
            }

        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            int index = kitap.FindIndex(x => x.KitapNo == txt_kitap_no.Text);
            if (index == -1)
                MessageBox.Show("Böyle bir kitap kaydı bulunmuyor");
            else
            {
                txt_sayfa.Text = "" + kitap[index].SayfaSayisi;
                txt_kitap_ad.Text = kitap[index].KitapAdi;
                txt_kitap_no.Text = kitap[index].KitapNo;
                txt_tur.Text = kitap[index].Turu;
                txt_yazar.Text = kitap[index].Yazar;
              

            }
        }

        private void btn_odunc_al_Click(object sender, EventArgs e)
        {
            Kitap tmpkitap = new Kitap();
            Ogrenci tmpogrenci = new Ogrenci();
            if (txt_ogrenci_no.Text == "" || txt_ogrenci_ad.Text == "" || txt_ogrenci_soyad.Text == "")
            {
                MessageBox.Show("Öğrenciye ait bütün alanların doldurulması gereklidir");
            }
            else
            {
                tmpkitap.KitapNo = txt_kitap_no.Text;
                tmpogrenci.OgrenciID = txt_ogrenci_no.Text;
                tmpkitap.KitapAdi = txt_kitap_ad.Text;
                tmpkitap.Yazar = txt_yazar.Text;
                tmpkitap.Turu = txt_tur.Text;
                tmpkitap.SayfaSayisi =(txt_sayfa.Text);
                tmpogrenci.Ad = txt_ogrenci_ad.Text;
                tmpogrenci.Soyad = txt_ogrenci_soyad.Text;
                tmpkitap.OduncVerildiMi = true;
                if (kitap.FindIndex(s => s.KitapNo == tmpkitap.KitapNo) == -1)
                {                   
                    MessageBox.Show("Böyle bir kitap bulunmamaktadır");
                }

                else
                {
                    MessageBox.Show("Kitap Başarıyla Ödünç verilmiştir");
                    ogrenci.Add(tmpogrenci);
                    for (int i = dataGridView1.Rows.Add(); i < ogrenci.Count; i++)
                    {
                        //var indeks = kitap.FindIndex(s => s.Contains(txt_kitap_no.Text));
                        dataGridView1.Rows[i].Cells[0].Value = txt_kitap_no.Text;
                        dataGridView1.Rows[i].Cells[1].Value = kitap[(kitap.FindIndex(s => s.KitapNo == txt_kitap_no.Text))].KitapAdi;
                        dataGridView1.Rows[i].Cells[2].Value = kitap[(kitap.FindIndex(s => s.KitapNo == txt_kitap_no.Text))].Yazar;
                        dataGridView1.Rows[i].Cells[3].Value = kitap[(kitap.FindIndex(s => s.KitapNo == txt_kitap_no.Text))].SayfaSayisi;
                        dataGridView1.Rows[i].Cells[4].Value = kitap[(kitap.FindIndex(s => s.KitapNo == txt_kitap_no.Text))].Turu;
                        dataGridView1.Rows[i].Cells[5].Value = txt_ogrenci_no.Text;
                        dataGridView1.Rows[i].Cells[6].Value = txt_ogrenci_ad.Text;
                        dataGridView1.Rows[i].Cells[7].Value = txt_ogrenci_soyad.Text;

                    }
                    kitap.RemoveAll(a => a.KitapNo == txt_kitap_no.Text);
                    label9.Text = kitap.Count.ToString();


                }
                    
           

        }
        }
    }
}