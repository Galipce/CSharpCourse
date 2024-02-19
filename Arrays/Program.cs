using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string student1 = "Galip";
            //string student2 = "Engin";
            //string student3 = "Ahmet";

            string[] students = new string[3] { "Galip", "Engin", "Ahmet" };
            //students[0] = "Galip";
            //students[1] = "Engin";
            //students[3] = "Ahmet";

            string[] students2 = { "Galip", "Engin", "Ahmet" };

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            string[,] regions = new string[5, 3]
            {
                {"İstanbul","İzmit","Balıkesir" },
                {"Ankara","Konya","Kırıkkale" },
                {"Antalya","Adana","Mersin" },
                {"Rize","Trabzon","Samsun" },
                {"İzmir","Muğla","Manisa" }
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);

                }

                Console.WriteLine("************************");
            }



            Console.ReadLine();
        }
    }
}
