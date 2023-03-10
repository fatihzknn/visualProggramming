using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //var result = Add2(2, 30);

            //int number1 = 20;
            //int number2 = 100;
            //var result2 = Add3(ref number1 + number2);
            //Console.WriteLine(number1);
            // number1 20 olarak basıldı değişikliğe uğramadı bunu değiştirmek için referans göndermek gerekir  ref ile
            // eğer ref ile yaparsan set işlemi yapman lazım o değere fakat out ile yaparsan buna gerek kalmaz


            //Console.WriteLine(result);
            //Console.WriteLine(result2);
            //Console.WriteLine(Multiply(2, 3));
            //Console.WriteLine(Multiply(2, 3, 4)); 
            
            Console.WriteLine(Add4(1,2, 3,4,5,6));
            Console.ReadLine();
        }

        

        static void Add()
        {
            Console.WriteLine("Added");
        }

        static int Add2(int number1, int number2 = 30)
        {
            // default değer verilebilir parametre olarak istersen bu methodu çağırdığında değiştirebilirsin ya da default olarak kalabilir
            var result = number1 + number2;
            return result;
        }

        static int Add3(ref int  number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Multiply(int number1 , int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
            // methodların overloadı denir. Fazladan  parametrre varsa tekrardan ismini değiştirmene gerek yok
        {
            return number1 * number2 * number3;
        }

        static int Add4(params int[] numbers)
            // istediğimiz kadar parametre gönderebiliriz
        {
            return numbers.Sum();
        }
    }
}
