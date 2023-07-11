﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class Program
    {
        static void Main(string[] args)
        {
            Product harddisk = new Product(50);
            harddisk.ProductName = "Harddisk";

            Product gsm = new Product(50);
            gsm.ProductName = "Telefon";
            gsm.StockControlEvent += Gsm_StockControlEvent;

            for (int i = 0; i < 10; i++)
            {
                harddisk.Sell(10);
                gsm.Sell(10);
                Console.ReadLine();
            }

            Console.ReadLine();

        }

        private static void Gsm_StockControlEvent()
        {
            Console.WriteLine("Gsm About To Finish");
        }
    }
}
