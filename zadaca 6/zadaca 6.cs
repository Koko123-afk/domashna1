using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaca_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());  
            Console.WriteLine("Sbora na chislata e"+ (a+b));
            while (b != 0)
            {
                var B = b;
                b = a % b;
                a = B;
            }
            Console.WriteLine("NOD =" + a);
        }
    }
}
