﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domashnichka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                if (!(i % 4 == 0 || i % 8 == 0))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
