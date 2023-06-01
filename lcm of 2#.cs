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
            int num1, num2, x, y, lcm = 0;
            Console.Write("Enter the First Number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the Second Number : ");
            num2 = int.Parse(Console.ReadLine());
            x = num1;
            y = num2;
            while (num1 != num2)
            {
                if (num1 < num2)
                {
                    num1 += x;
                }
                else
                {
                    num2 += y;
                }
            }
            lcm = num2; // LCM is equal to either num1 or num2
            Console.WriteLine("Least Common Multiple is: " + lcm);
            Console.ReadKey();
        }
    }
}
