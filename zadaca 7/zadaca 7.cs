using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaca_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи число :");
            int num = int.Parse(Console.ReadLine());
            var result = true;
            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    result = false;
                    break;
                }
            }
            if (result == true)
            {
               Console.WriteLine($"Числото {num} е просто");
            }
            else
            {
               Console.WriteLine($"Числото {num} е сложно"); 
            }
        }
    }
}
