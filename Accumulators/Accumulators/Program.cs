using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accumulators
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            double product = 1;
            int number = 1;

            do
            {
                sum = sum + number;
                product = product * number;
                number = number + 1;
            } while (number != 101);

            Console.WriteLine($"The numbers 1 to 100 added together is {sum}.");
            Console.WriteLine($"The numbers 1 to 100 multiplied together is {product.ToString("N0")}.");

            Console.ReadKey();
        }
    }
}
