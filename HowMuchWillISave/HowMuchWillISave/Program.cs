using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowMuchWillISave
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much money will you save in a week? >>");
            double savings = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How much interest rate do you get per month? (ex. 4.5) >>");
            double rate = Convert.ToDouble(Console.ReadLine()) / 100;
            Console.WriteLine("How many years would you like to save for? >>");
            int years = Convert.ToInt32(Console.ReadLine());

            int numMonth = 1;
            int numYears = 1;
            string monthName;
            double total = 0;

            for (int month = 1; month <= years*12; month++)
            {
                total = total + savings * 4;
                total = total + total * rate;

                if (numMonth == 1)
                {
                    monthName = "January";
                }
                else if (numMonth == 2)
                {
                    monthName = "February";
                }
                else if (numMonth == 3)
                {
                    monthName = "March";
                }
                else if (numMonth == 4)
                {
                    monthName = "April";
                }
                else if (numMonth == 5)
                {
                    monthName = "May";
                }
                else if (numMonth == 6)
                {
                    monthName = "June";
                }
                else if (numMonth == 7)
                {
                    monthName = "July";
                }
                else if (numMonth == 8)
                {
                    monthName = "August";
                }
                else if (numMonth == 9)
                {
                    monthName = "September";
                }
                else if (numMonth == 10)
                {
                    monthName = "October";
                }
                else if (numMonth == 11)
                {
                    monthName = "November";
                }
                else
                {
                    monthName = "December";
                }
                Console.WriteLine($"{monthName}, year {numYears}: {total.ToString("C2")}");
                numMonth = numMonth + 1;
                //when the the month divided by 12 is 0 (so when it's december) go to the next year
                if (month % 12 == 0)
                {
                    numYears = numYears + 1;
                    numMonth = 1;
                }
            }
            Console.ReadKey();
        }
    }
}
