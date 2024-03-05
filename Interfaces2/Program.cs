using System;

namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    interface IPersonManager
    {
        void Add();
    }

    class CustomerManager : IPersonManager
    {
        
        public void Add()
        {
            //Müşteri Ekleme Kodları
            Console.WriteLine("Müşteri Eklendi");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Employee Eklendi");
        }
    }
}