using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaca_4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            double n = double.Parse(Console.ReadLine());
            Console.Write("x=");
            double x = double.Parse(Console.ReadLine());
            double x2 = x;
            double c = 1;
            double s = 1;
            double f = 1;
            while (c <= n)
            {
                s = s + (f / x);
                c++;
                x = x * x2;
                f = f * c;
            }
            Console.WriteLine("s= " + s);
        }
    }
}
