﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaca_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i <= 25; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"                {i} -> {i * i}");
                }
                else
                    Console.WriteLine($"{i} -> {i * i * i}");
            }
        }
    }
}
