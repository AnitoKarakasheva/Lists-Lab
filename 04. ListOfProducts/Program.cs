﻿using System;
using System.Collections.Generic;

namespace _04._ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            List<string> products = new List<string>(counter);

            for (int i = 0; i < counter; i++)
            {
                products.Add(Console.ReadLine());
            }
            products.Sort();
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
        }
    }
}
        
