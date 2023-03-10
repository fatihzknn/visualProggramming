using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "My name is Fatih Han Özkan";
            var result = sentence.Length;
            var result2 = sentence.Clone(); 
            sentence = "My name is Kaan Karyağdı";
            bool result3 = sentence.EndsWith("n"); // Cümle n ile bitiyormu diye sorgular boolean değer döndürür.

            bool result4 = sentence.StartsWith("My name");

            var result5 = sentence.IndexOf("name");// name hangi indexten başlıyorsa onu gösterir, bulamaz ise -1 döndürür.

            var result6 = sentence.IndexOf(" "); // ilk gördüğü değeri söyler.

            var result7 = sentence.LastIndexOf(" "); // aramaya sondan başlar

            var result8 = sentence.Insert(0, "Hello, "); // başına verilen değişkeni ekler ilk parametre nereden başlanılacağını söyler.

            var result9 = sentence.Substring(3,4); // 3. karakterden itibaren olanları kaydeder. 4 tane bit al.

            var result10 = sentence.ToLower(); // tüm karakterler küçük harge çevirir

            var result11 = sentence.ToUpper(); // tüm karakterler büyük olur

            var result12 = sentence.Replace(" ","-");

            var result13 = sentence.Remove(2,4); // 2 den itibaren 4 tane sil


            Console.WriteLine(result13);//Result2 değişmez klonladığımız için my name is fatih han özkan yazdırır
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }
            string city2 = "İstanbul";
            Console.WriteLine(String.Format("{0} {1}", city, city2)); // stringleri yan yana toplamak yerine format kullanılabilir.
        }
    }
}
