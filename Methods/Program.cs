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
            Add();

            var result = Add2(2, 3);
            var result2 = Add2(2);
            Console.WriteLine(result);
            Console.WriteLine(result2);

            int number1 = 20;
            int number2 = 100;
            var result3 = Add3(ref number1, number2);
            Console.WriteLine(result3);

            Console.WriteLine(Multiply(2,4,5));

            Console.WriteLine(Add4(1,2,3,4,5,6,7));



            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        // default değerler methodların sonunda olmalı parametrelerin sonunda olmalı
        
        static int Add2( int number1, int number2 = 20)
        {
            return number1 + number2;
        }
        //ref keywordu değer tiplerini referans tip olarak göndermeye yarar
        //bir diğer alternatifi de out'tur out da değerin setlenmiş olmasına gerek yoktur
        //outta method içerisinde set edilmesi gerekmektedir.
        static int Add3(ref int number1, int number2)
        {
            return number1 + number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
