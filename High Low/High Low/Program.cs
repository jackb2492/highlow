using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_Low
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome message

            Console.WriteLine("Welcome to the High Low game");

            // Choose random number
            Random rng = new Random();
            int number = rng.Next(1, 11);
            int tries = 0;

            while (true)
            {

                // Enter user guess
                Console.WriteLine("Enter guess :"); 
                int guess = Convert.ToInt32(Console.ReadLine());
                tries = tries + 1;
                
               

            
                // Compare guess to number
                if (guess < number)
                {
                    Console.WriteLine("Too low, go higher.");


                }
                else if (guess > number)
                {
                    Console.WriteLine("Too high, go lower");
                }
                else
                {
                    Console.WriteLine("Correct well done.");
                    Console.WriteLine(tries.ToString()+ " guesses");
                    break;
                }
            }
            
            // Wait for a key press

            Console.ReadKey();
        }
    }
}
