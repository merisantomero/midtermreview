using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a word or phrase.");
            string response = Console.ReadLine().ToLower();

            string backwards = "";

            for (int i = response.Length - 1; i >= 0; i--)
            {
                backwards = backwards + Convert.ToString(response[i]);
            }

            if (response == backwards)
            {
                Console.WriteLine($"Yay, {response} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"Sorry, {response} is not a palindrome because backwards it is {backwards}.");
            }

            Console.ReadKey();
        }
    }
}
