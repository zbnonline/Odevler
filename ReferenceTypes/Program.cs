using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi1 = 100;
            int sayi2 = sayi1;
            sayi1 = 300; // burada belirtilen sayi1 ve sayi2 değişken tip olduğundan bunlar direkt değer alır. Referans numarası atanmaz. sayi2 = sayi1 demek arka planda sayi2 = 100 değerine karşılık verir bu yüzden sayi1'in sonrasında aldığı değereler sayi2'de bir değişiklik olmasına sebep olmaz
            


            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Anıl";
            person2 = person1;
            person1.FirstName = "Ömer"; // Person2'ye person1'in referans numarası atandığı için person2'nin firstname değeri de ömer ile değişmiş olur.



            Customer customer = new Customer();
            Employee employee = new Employee();

            // customer = employee ataması yapılamaz çünkü farklı referans tiplerine sahipler

            Person person3 = new Person();
            customer.FirstName = "Anıl";
            person3 = customer; // Customer'ın base class (üretildiği class) person olduğu için bu atama yapılabilmektedir.
            customer.CreditCardNumber = "6161616161";
            Console.WriteLine(((Customer)person3).CreditCardNumber); // person3 ' e customer class ından erişip değerlerini getirebiliriz
            
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    // Base Class : Person || Person Classından üretilen Customer Class'ı 
    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }

    // Base Class : Person || Person Classından üretilen Employee Class'ı 
    class Employee: Person
    {
        public int EmployeeNumber { get; set; }
    }
}
