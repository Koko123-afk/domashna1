using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaca_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            string dvoichno = Convert.ToString(n, 2);
            Console.WriteLine($"Dvoichnoto predstavqne e: {dvoichno}");
        }
    }
}
