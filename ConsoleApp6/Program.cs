using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f = 1, num;
            Console.WriteLine("enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i =1; i <=num;i++)
            {
                if (num == 0) break;
                f *= i;
            }
            Console.WriteLine("{0}={1})", num, f);
                Console.ReadKey();
        }
    }
}
