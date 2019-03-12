using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************");
            Console.WriteLine("********TASK 6*********");
            Console.WriteLine("***********************");
            //Ask the user for the 3 letter word letter by letter
            Console.WriteLine("3 Letter word Palindrome checker. ");
            Console.WriteLine("please enter your first letter: ");
            string letter1 = Console.ReadLine();
            Console.WriteLine("please enter your Second letter: ");
            string letter2 = Console.ReadLine();
            Console.WriteLine("please enter your Third letter: ");
            string Letter3 = Console.ReadLine();
            //Checlk if the first and last letters are the same
            if (letter1 == Letter3)
            {
                //check if the middle letter is a vowel
                if (letter2 == "a" || letter2 == "e" || letter2 == "i" || letter2 == "o" || letter2 == "u")
                    //using the place holders to show the variables in the string output
                    Console.WriteLine("{0}{1}{2} is a palindrome", letter1, letter2, Letter3);
                else
                    Console.WriteLine("I dont think that's a real word.");
            }
            else
                Console.WriteLine("{0}{1}{2} isn't a palindrome.", letter1, letter2, Letter3);

            Console.WriteLine("Task 6 finished. Please press enter to continue.....");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
