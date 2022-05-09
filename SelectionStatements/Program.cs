using System;

namespace SelectionStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--------------------------------------------Exercise 1--------------------------------------------------
            //var r = new Random();
            //int favoriteNumber = r.Next(1,1000);
            //int guess;

            //Console.WriteLine("Welcome to the number guessing game!");
            //Console.Write("Please enter a number between 1 -1000: ");
            //guess = int.Parse(Console.ReadLine());

            //if (guess < favoriteNumber)
            //{
            //    Console.WriteLine("Too Low!");
            //}
            //else if (guess > favoriteNumber)
            //{
            //    Console.WriteLine("Too High!"); 
            //}
            //else
            //{
            //    Console.WriteLine("You Got It!!");
            //}

            //--------------------------------------------Exercise 2--------------------------------------------------

            Console.WriteLine("Please choose from the following subjects: PE, History, Math, English, and Science.");

            Console.Write("Enter your favorite subject in school: ");
            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "pe":
                case "physical education":
                    Console.WriteLine("Your favorite subject is PE.");
                    break;
                case "history":
                    Console.WriteLine("Your favorite subject is History.");
                    break;
                case "math":
                    Console.WriteLine("Your favorite subject is Math.");
                    break;
                case "english":
                    Console.WriteLine("Your favorite subject is English.");
                    break;
                case "science":
                    Console.WriteLine("Your favorite subject is Science.");
                    break;
                default:
                    Console.WriteLine($"This ins't a subject on the list. (Please, Check your spelling and try again)");
                    break;
            }







        }
    }
}
