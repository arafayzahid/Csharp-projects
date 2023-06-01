using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];

            Console.WriteLine("Enter 5 +ve Elements:");
            for (int i = 0; i < 5; i++)
            {
                a[i] = Convert.ToInt16(Console.ReadLine());
                if (a[i] > 0)
                    a[i] = -a[i];
            }

            Console.WriteLine("-ve Elements:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadLine();
        }
    }
}
