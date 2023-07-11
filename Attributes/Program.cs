using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, LastName = "Zabunoğlu", Age = 22 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadLine();
        }
    }

    [Totable("Customers")]
    [Totable("TblCustomers")]
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }
    }

    class CustomerDal
    {
        [Obsolete("Addnew methodunu kullan!")] 
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added",customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }

        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }

    [AttributeUsage(AttributeTargets.Property)] // Bu attribute ün nerelerde kullanılabileceğini kısıtlayabileceğimiz method, birden fazla eklenmek isterse "|" koyulup diğer kullanılacak yer yazılabilir.
    class RequiredPropertyAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class,AllowMultiple = true)] // Allowmultiple bu attribute un aynı yerde birden fazla kullanılabilirliğini kontrol edebilmemiz için kullanılır
    class TotableAttribute : Attribute
    {
        private string _tableName;

        public TotableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }
}
