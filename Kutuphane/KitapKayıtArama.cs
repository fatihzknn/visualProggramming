using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kutuphane
{
    public partial class KitapKayıtArama : Form
    {
        public List<Kitap> kitap = new List<Kitap>();
       
        public KitapKayıtArama()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void KitapKayıtArama_Load(object sender, EventArgs e)
        {

        }
       
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            
            if (txt_kitap_no.Text == "" || txt_kitap_ad.Text == "" || txt_sayfa.Text == "" || txt_yazar.Text == ""  || txt_tur.Text == "")
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
                tmpkitap.SayfaSayisi = Convert.ToInt32(txt_sayfa.Text);
                if (kitap.FindIndex(s => s.KitapNo == tmpkitap.KitapNo) == -1) 
                {
                    kitap.Add(tmpkitap);
                    lbl_mevcut_kitap.Text = kitap.Count.ToString();
                    MessageBox.Show("Kitap Başarıyla Sisteme Kayıt Edilmiştir");
                }
                    
                else
                    MessageBox.Show("Girdiğiniz ID de zaten kayıt bulunmaktadır");
            }

            
          
            
            
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            string aranan_No = txt_kitap_no.Text;
            bool bulundu_Mu = false;
            if (aranan_No == "")
            {
                MessageBox.Show("KitapNo kısmı boş bırakılamaz");
            }
            else
            {
                for (int i = 0; i < kitap.Count; i++)
                {
                    if (aranan_No == kitap[i].KitapNo)
                    {
                        bulundu_Mu = true;
                        txt_kitap_no.Text = kitap[i].KitapNo;
                        txt_kitap_ad.Text = kitap[i].KitapAdi;
                        txt_sayfa.Text = Convert.ToString(kitap[i].SayfaSayisi);
                        txt_tur.Text = kitap[i].Turu;
                        txt_yazar.Text = kitap[i].Yazar;
                    }
                }
                if (!bulundu_Mu)
                {
                    MessageBox.Show("Aradığınız kitap no ile eşleşen kitap bulunmamaktadır.");
                }
            }
        }
    }
}
