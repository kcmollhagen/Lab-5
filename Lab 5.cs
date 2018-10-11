using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string y;
            // Do Loop - guarenteed to execute at least one time
            do
            {
                // The user is prompted to input an integer
                // That integer will be calculated to it's factorial
                long i, number, fact;
                Console.WriteLine("Enter an integer that's greater than 0 but less than 21:");
                number = int.Parse(Console.ReadLine());
                fact = number;
                for (i = number - 1; i >= 1; i--)
                {
                    // Formula to calculate the factorial
                    fact = fact * i;
                }
                Console.WriteLine("\nFactorial of the integer is: " + fact);
                Console.WriteLine("Do you want to continue?" + "(y/n)");
                y = Console.ReadLine();
            }
            // While Loop - repeatedly executes target statement as long as given condition is true
            while (y == "y");
            }
           
        }
    }

