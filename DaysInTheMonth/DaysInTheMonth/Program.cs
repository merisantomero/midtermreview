using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysInTheMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt the user to input the name of the month
            Console.WriteLine("Input the name of the month. (ex. January, February, ...)");
            string month = Console.ReadLine();

            int days;
            //determine how many days there are in the month
            if (month == "January")
            {
                days = 31;
            }
            else if (month == "February")
            {
                Console.WriteLine("Is it a leap year? yes or no >>");
                string leap = Console.ReadLine();
                if (leap == "yes")
                {
                    days = 29;
                }
                else
                {
                    days = 28;
                }
            }
            else if (month == "March")
            {
                days = 31;
            }
            else if (month == "April")
            {
                days = 30;
            }
            else if (month == "May")
            {
                days = 31;
            }
            else if (month == "June")
            {
                days = 30;
            }
            else if (month == "July")
            {
                days = 31;
            }
            else if (month == "August")
            {
                days = 31;
            }
            else if (month == "September")
            {
                days = 30;
            }
            else if (month == "October")
            {
                days = 31;
            }
            else if (month == "November")
            {
                days = 30;
            }
            else
            {
                days = 31;
            }

            //output the amount of days in the user's response
            Console.WriteLine($"There are {days} days in {month}.");

            Console.ReadKey();
        }
    }
}
