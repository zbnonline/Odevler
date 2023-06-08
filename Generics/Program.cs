using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Eskişehir");
            Console.WriteLine(sehirler.Count);

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Eskişehir");
            Console.WriteLine(sehirler2.Count);
        }
    }

    class MyList<T> // Generic class 
    {
        T[] _array;
        T[] _tempArray;  // 2 tane boş array üretiyoruz
        public MyList()
        {
            _array = new T[0]; // Arrayi sıfır elemanlı olarak başlatıyoruz
        }
        public void Add(T item)
        {
            _tempArray = _array; // Eski verileri kaybetmemek için verileri tempArray'e aktarıyoruz
            _array = new T[_array.Length + 1]; // Array'imizin eleman sayısını gönderdiğimiz item'ı eklemek için bir arttırıyoruz. 

            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i]; // _tempArray'e aktardığımız verileri tekrar _array içine aktarıyoruz
            }

            _array[_array.Length - 1] = item; // arrayın eleman sayısını bulup son boş kalan yere gönderdiğimiz item'ı yazdırıyoruz
        }

        public int Count
        {
            get { return _array.Length; }
        }
    }
}
