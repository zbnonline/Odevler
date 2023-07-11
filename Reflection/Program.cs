using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2, 3);
            //Console.WriteLine(dortIslem.Topla(3, 4));
            //Console.WriteLine(dortIslem.Topla2());

            var type = typeof(DortIslem);

            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(type,6,6);
            //Console.WriteLine(dortIslem.Topla(5,6));
            //Console.WriteLine(dortIslem.Topla2());

            var instance = Activator.CreateInstance(type, 6, 6);
            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2"); // GetMethod ile çalışmak istediğimiz methodu getiririz
            Console.WriteLine(methodInfo.Invoke(instance, null)); // Invoke ile de bu methodu çalıştırırız

            var methodlar = type.GetMethods(); // type ın içinde ki methodları getirir,
            Console.WriteLine("----------------------------");
            foreach (var info in methodlar)
            {
                Console.WriteLine("Method Adı: "+info.Name);
                foreach (var parameterInfo in info.GetParameters()) // Methodların içinde ki parametreleri getirir
                {
                    Console.WriteLine("Parametre Adı: "+parameterInfo.Name);
                }

                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Adı: "+attribute.GetType().Name);
                }
            }

            Console.ReadLine();
        }
    }

    public class DortIslem
    {
        int _sayi1;
        int _sayi2;

        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }

        public DortIslem()
        {

        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }

        [MethodName("Carpma")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }
    }

    public class MethodNameAttribute: Attribute
    {
        public MethodNameAttribute(string name)
        {

        }
    }
}
