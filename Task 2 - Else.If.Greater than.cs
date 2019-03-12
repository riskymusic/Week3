using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************");
            Console.WriteLine("********TASK 2*********");
            Console.WriteLine("***********************");
            //answer below to question is 7//
            int number = 7;
            //Question below with "guess"//
            Console.WriteLine("Try and guess my number from 1 to 10: ");
            int guess = int.Parse(Console.ReadLine());
            // == means the correct answer - links the question to the outcome//
            if (guess == number)
                Console.WriteLine("you got it, good shit mother fucker your right!");
            else if (guess > number)
                // else if it isnt correct or greater ">" is used to send a response to your answer//
                Console.WriteLine("your number is greater than the answer, Please try again");
            else
                // else gives you the opposite of else if //
                Console.WriteLine("sorry your guess is lower than the answer, Please try again");

            Console.WriteLine("Task 2 finished. Please press enter to continue.....");
            Console.ReadLine();
            Console.Clear();
                     
                 

        }
    }
}
