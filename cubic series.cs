using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("The Series Is:");
            int i = 1;
            int count = 1;
            int sum = 0;

            for (int j = 1; j <= 10; j++)
            {
                i = j * j * j;
                count++;
                Console.WriteLine(i);
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine("The Sum Of The Above Series Is =" + sum);
            Console.ReadLine();
        }
    }
}
