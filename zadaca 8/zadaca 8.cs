using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaca_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Na koe da razdelq?");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Na koe da se deli");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Kolko chisla shte razdelqte?");
            int n =int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % a == 0 && num % b != 0)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
