using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
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
            customer.City = "İstanbul";
            customer.FirstName = "Ömer";
            customer.LastName = "Zabunoğlu";
            customer.Id = 1;

            Customer customer1 = new Customer()
            {
                Id = 1, City = "İstanbul", FirstName = "Anıl", LastName = "Zabunoğlu"
            };

            Console.WriteLine(customer1.FirstName);

            Console.ReadLine();
        }
    }    
}
