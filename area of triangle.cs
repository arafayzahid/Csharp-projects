using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Enter The Length Of The Triangle =");
                double length1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter The Base Of The Triangle =");
                double base1 = Convert.ToDouble(Console.ReadLine());

                double area = (length1 * base1) / 2;
                Console.WriteLine("The Area Of A Triangle Is =" + area);
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
