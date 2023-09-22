using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Value: ");
            int value = Convert.ToInt32(Console.ReadLine());
            if (value % 3 == 0 || value % 7 == 0)
            {
                Console.WriteLine("True");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("False");
                Console.ReadLine();
            }
        }
    }
}
