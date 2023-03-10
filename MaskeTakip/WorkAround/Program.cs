using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkAround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    SelamVer("Engin");
            //    SelamVer("Fatih");
            //    SelamVer("Ayşe");
            //    SelamVer("Selami");
            //    SelamVer();

            //    int sonuc  = Topla();
            //    // MyList

            //    List<string> yeniSehirler1 = new List<string> { "Ankara","İstanbul","İzmir"};
            //    yeniSehirler1.Add(item : "İzmir");
            //    foreach (var sehir in yeniSehirler1)
            //    {
            //        Console.WriteLine(sehir);
            //    }

            Person person = new Person();
            person.FirstName = "Fatih";
            person.LastName = "Özkan";
            person.DateOfBirthYear = 2001;
            person.NationalIdentity = 123;
            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person);
            
            Console.ReadLine();


        }
   
    } 
}
