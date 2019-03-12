using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("*****************************");
            Console.WriteLine("************TASK  5**********");
            Console.WriteLine("*****************************");

            Console.WriteLine("Please enter a 4 digit pin number: ");
            int pin1 = int.Parse(Console.ReadLine());
        
        
            if (pin1 >1000 && pin1< 9999)
            {
                Console.WriteLine("please re-enter your pin: ");
                int pin2 = int.Parse(Console.ReadLine());
                if (pin1 == pin2)
                    Console.WriteLine("pin Accepted.");
                else Console.WriteLine("your pins did not match.");
            }
            else Console.WriteLine("your pin did not meet the requirements.");

            Console.WriteLine("Task 5 finished. Please press enter to continue.....");
            Console.ReadLine();
            Console.Clear();
                                
        }
    }
}
