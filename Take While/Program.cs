﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace TakeWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> ResultMS = numbers.TakeWhile(num => num < 6).ToList();

            foreach (var num in ResultMS)
            {
                Console.Write($"{num} ");
            }
            Console.ReadKey();
        }
    }
}
