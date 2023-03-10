using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphanebasic
{
    public class Kitap
    {

        public string KitapNo { get; set; }
        public string KitapAdi { get; set; }
        public string Yazar { get; set; }
        public string Turu { get; set; }
        public string SayfaSayisi { get; set; }
        public string OgrenciNo { get; set; }
        
        public bool OduncVerildiMi = false;


    }
}
