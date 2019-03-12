using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
           //Task 1//
            Console.WriteLine("***************************");
            Console.WriteLine("**********TASK 1***********");
            Console.WriteLine("***************************");

            //asks you question on typing two num//
            Console.Write("Please enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Please enter another number: ");
            int num2 = int.Parse(Console.ReadLine());

            //connects both numbers to see if they indicate to equal the same//
            if (num1 == num2)
                //if quals the same it will say that the two numbers equal//
                Console.WriteLine("The two numbers you entered are equal. ");
            //> if larger than the number it will say its larger by default//
            else if (num1 > num2)
                Console.WriteLine($"The first number entered, {num1}, is the larger of the two.");
            else
                Console.WriteLine($"The second number entered, {num1}, is the larger of the two.");

            Console.WriteLine("Task 2 finished. Please press enter to continue.....");

            Console.ReadLine();
            Console.Clear();
            //this task gives a clear idea on how to go two different ways with code so that it will get you to the correct answer//

        
        }
    }
}
