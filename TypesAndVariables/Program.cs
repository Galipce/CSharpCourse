using System;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Value Types

            //Console.WriteLine("Hello Wrold");

            //sınır -2147483648 ile 2147483647
            int number1 = 2147483647; //32 bit
            Console.WriteLine("Number1 is {0}", number1);

            //sınır -9223372036854775808 ile 9223372036854775807
            long number2 = -9223372036854775808; //64Bit
            Console.WriteLine("Number1 is {0}", number2);

            //sınır -32768 ile 32767
            short number3 = -32768; //32bit
            Console.WriteLine("Number1 is {0}", number3);

            //sınır 0 ile 255 arası
            byte number4 = 0; //16bit
            Console.WriteLine("Number1 is {0}", number4);

            bool condition = true; // ya da false olur

            //ASCII yani klavyedeki karakterleri tutar
            char character = 'A';
            //string karakter dizisidir 
            Console.WriteLine(character); //(int) yazarsak başına sayı karşılığını verir

            double number5 = 10.4; //64bit
            Console.WriteLine(number5);

            //daha hassas veriler için vigülden sonra 28-29 basamak tutabilir doubledan daha fazla
            decimal number6 = 10.4m;
            Console.WriteLine(number6);

            //enum console yazımı
            Console.WriteLine(Days.Friday);

            var number7 = 10;
            Console.WriteLine(number7);
            number7 = 'A';
            //number7 = "A"; bu şekilde veri tipini değiştiremeyiz
            Console.WriteLine(number7);


            Console.ReadLine();
        }
    }

    //güzel olay enum sabitleri özellikle conditionlarda baya iyi    
    enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }

}
