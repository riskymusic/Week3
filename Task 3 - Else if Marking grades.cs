using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    { //Name: Tama Owens 
        //Task 3//
        static void Main(string[] args)
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("************TASK  3**********");
            Console.WriteLine("*****************************");
            //as the user for there mark and stores it in a float variable(just incase they try to enter a decimal//
            Console.WriteLine("Please enter your final mark: ");
            float mark = float.Parse(Console.ReadLine());
            //Checking the mark using if, else if and else statements 
            if (mark >= 90 && mark <= 100)
                Console.WriteLine("Your grade is an A+");
            else if (mark >= 80 && mark <= 89)
                Console.WriteLine("Your grade is an A");
            else if (mark >= 70 && mark <= 79)
                Console.WriteLine("Your grade is an B+");
            else if (mark >= 60 && mark <= 69)
                Console.WriteLine("Your grade is an B");
            else if (mark >= 50 && mark <= 59)
                Console.WriteLine("Your grade is an C");
            else if (mark >= 40 && mark <= 49)
                Console.WriteLine("Your grade is an D");
            else if (mark >= 30 && mark <= 39)
                Console.WriteLine("Your grade is an F");
            else
                Console.WriteLine("There was a problem with the mark you entered");
            //Give the user a meaningfull output to let them know this part is complete
            Console.WriteLine("Task 3 finished. Please press enter to continue......");
            //below readline is used to pause the program so the user can see the output
            Console.ReadLine();
            Console.Clear();





        }
    }
}
