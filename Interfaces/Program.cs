using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //Demo2();

            ICustomerDal[] customerDals= new ICustomerDal[3] 
            {
                new SqlServerCustomerDal(), 
                new OracleServerCustomerDal(),
                new MySqlServerCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }

        private static void Demo2()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleServerCustomerDal());

            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            //PersonManager manager = new PersonManager();
            //manager.Add(new Customer { Id = 1, FirstName = "Galip", LastName = "Badem", Address = "istanbul" });

            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Galip",
                LastName = "Badem",
                Address = "istanbul"
            };
            manager.Add(customer);

            Student student = new Student
            {
                Id = 1,
                FirstName = "Galip",
                LastName = "Badem",
                Department = "Computer Sciences"
            };
            manager.Add(student);

            Student worker = new Student
            {
                Id = 1,
                FirstName = "Galip",
                LastName = "Badem",
                Department = "Computer Sciences"
            };
            manager.Add(worker);
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
