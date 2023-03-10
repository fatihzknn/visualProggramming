using InterfaceAbstructDemo.Abstract;
using InterfaceAbstructDemo.Adapters;
using InterfaceAbstructDemo.Concrete;
using InterfaceAbstructDemo.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstructDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(2010, 1, 11), FirstName = "Yunus Emre", LastName = "Özkan", NationalityId = "50224243158" });
            Console.ReadLine();
        }
    }
}
