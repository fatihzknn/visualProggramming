using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    class Kisi
    {
        public string ad;
        public string soyad;
        public string yas;
    }
    internal class Program
    {
    
        static void Main(string[] args)
        {
            Kisi k1 = new Kisi();
            k1.ad = "Fatih";
            k1.soyad = "Özkan";
            k1.yas = "21";
            Kisi k2 = new Kisi() { ad = "Kaan", yas = "21", soyad = "Karyağdı"};
            Console.WriteLine(k1.ad + k1.soyad + k1.yas);
            Console.Read();
        }
        
    }
}
