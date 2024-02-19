using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Finished!");

            //-----------------------------------------------
            //int number = 100;

            //while (number >= 0)
            //{
            //    Console.WriteLine(number);
            //    number--;
            //}
            //Console.WriteLine("Now number is {0}",number);

            //--------------------------------------------------

            //int number = 10;
            //do
            //{
            //    Console.WriteLine(number);
            //    number--;
            //} while (number >= 11);

            //--------------------------------------------------

            //string[] students = new string[3] { "Galip", "Engin", "Ahmet" };

            //foreach (var student in students)
            //{
            //    Console.WriteLine(student);
            //}

            //-------------------------------------------------

            if (IsPrimeNumber(6))
            {
                Console.WriteLine("This is prime number");
            }
            else
            {
                Console.WriteLine("This is not prime number");
            }
            Console.ReadLine();
        }

        //asal sayı bulma
        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number%i==0)
                {
                    result = false;
                    i = number;
                }
            }

            return result;
        }
    }
}
