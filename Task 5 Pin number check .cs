using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("*****************************");
                Console.WriteLine("************TASK  5**********");
                Console.WriteLine("*****************************");

                Console.WriteLine("Please enter a 4 digit pin number: ");
                int pin1 = int.Parse(Console.ReadLine());

                //Using nested if the statements to check if the pin is between the desired ranges then if the reentered pin matches.
                if (pin1 > 1000 && pin1 < 9999)
                {
                    Console.WriteLine("please re-enter your pin: ");
                    int pin2 = int.Parse(Console.ReadLine());
                    //Nested if statement(If inside an IF)
                    if (pin1 == pin2)
                        Console.WriteLine("pin Accepted.");
                    else Console.WriteLine("your pins did not match.");
                }
                else Console.WriteLine("your pin did not meet the requirements.");

                //Give the user a meaningfull output to let them know this part is complete. 
                Console.WriteLine("Task 5 finished. Please press enter to continue.....");
                Console.ReadLine();
                Console.Clear();

            }
        }
    }
}

