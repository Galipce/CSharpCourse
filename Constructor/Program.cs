using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id=1, FirstName="Galip", Lastname="Badem", City="İstanbul"};

            Customer customer2 = new Customer(2, "Ali", "Veli", "İstanbul");

            Console.WriteLine(customer2.FirstName);

            Customer customer3 = new Customer();
            customer3.FirstName = "Laylay";
            customer3.Lastname = "Boyboy";
        }

    }

    class Customer
    {

        //Default Constructor
        public Customer()
        {

        }

        
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName=firstName;
            Lastname=lastName;
            City=city;
            //Console.WriteLine("Yapıcı blok çalıştı");
                
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string City { get; set; }
    }
}