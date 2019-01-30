/* Author: Jared Hanlon
   Date: 1/24/2019
   Comments: This C# console application demonstrates the use of
             Arrays after getting input from users.
*/

using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("");
                Console.WriteLine("Hello Dave, let's populate an array with integers.");
                Console.WriteLine("Then, let's iterate through the elements in the array with a foreach loop.");
                // Here is the manually populated array
                int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
                Console.WriteLine("__________________________________________________________________________");
                Console.WriteLine("");
                Console.WriteLine("The array has been populated by 25 elements.");
                Console.WriteLine("__________________________________________________________________________");
                Console.WriteLine("");
                // Iterate through the array using a Foreach Loop
                foreach(int i in numbers)
                {
                    Console.WriteLine("Element value = " + i);
                }
                Console.WriteLine("");
                Console.WriteLine("__________________________________________________________________________");
                //Pause the program and await the user to press a key to end the program
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
            } // End of try
             // If a user does not enter an integer, display a message
            catch
            {
                Console.WriteLine("I'm sorry Dave, I'm afraid I can't do that... ");
                Console.WriteLine("You have angered HAL. Press any key to exit the program and try again...");
                Console.ReadKey(true);
            } // End of catch
        } // End of main
    } // End of class
} // End of namespace
