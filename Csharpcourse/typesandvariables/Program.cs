using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typesandvariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Value Types
            // Console.WriteLine("Hello World");
            
            double number5 = 10.4;
            decimal number6 = 10.4m;
            short number3 = -32768;
            int number1 = 10;
            long number2 = 100000000000;
            bool condition = true;
            char character = 'A';
            string city = "Ankara";
            var number7 = 10;
            number7 = 'A';
            Console.WriteLine("Number1 is {0}",number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine("Number7 is {0}", number7);
            Console.WriteLine("Character is {0}", (int)(character));
            Console.WriteLine((int)Days.Friday);
            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    }
}
