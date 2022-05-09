using System;

namespace SelectionStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--------------------------------------------Exercise 1--------------------------------------------------
            var r = new Random();
            int favoriteNumber = r.Next(1,1000);
            int guess;

            Console.WriteLine("Welcome to the number guessing game!");
            Console.Write("Please enter a number between 1 -1000: ");
            guess = int.Parse(Console.ReadLine());

            if (guess < favoriteNumber)
            {
                Console.WriteLine("Too Low!");
            }
            else if (guess > favoriteNumber)
            {
                Console.WriteLine("Too High!"); 
            }
            else
            {
                Console.WriteLine("You Got It!!");
            }

            //--------------------------------------------Exercise 2--------------------------------------------------









        }
    }
}
