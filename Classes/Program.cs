using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.FirstName = "Galip";
            customer.Lastname = "Badem";
            customer.City = "İzmir";
            customer.Id = 1;

            Customer customer2 = new Customer
            {
                Id = 2,
                FirstName = "Galip",
                Lastname = "Badem",
                City = "İstanbul"
            };

            Console.WriteLine(customer2.FirstName);


            Console.ReadLine();
        }
    }

}
