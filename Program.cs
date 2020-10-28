using System;
using System.Collections.Generic;

namespace Day12_Blockbuster
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuChoice;
            string continueYN = "y";
            List<Movie> moviesCheckedOut = new List<Movie>();
            Blockbuster bb = new Blockbuster();
            while(continueYN == "y")
            {
                Console.Clear();
                bb.DisplayMenu();
                while (int.TryParse(Console.ReadLine().Trim(), out menuChoice) == false)
                {
                    Console.Write("You must enter 1 or 2: ");
                }

                switch (menuChoice)
                {
                    case 1:
                        Movie checkedMovie;
                        Console.Clear();
                        checkedMovie = bb.CheckOut();
                        moviesCheckedOut.Add(checkedMovie);
                        break;
                    case 2:
                        Console.Clear();
                        bb.PlayMovie();
                        break;
                    default:
                        break;
                }

                Console.Write($"{Environment.NewLine}Would you like to continue? (y or n): ");
                continueYN = Console.ReadLine().Trim().ToLower();
                while(continueYN != "y" && continueYN != "n")
                {
                    Console.Write("You must enter y or n: ");
                    continueYN = Console.ReadLine();
                }
            }

            Console.Write("You have checked out ");
            foreach (var movie in moviesCheckedOut)
            {
                Console.Write($"{movie.Title}, ");
            }
            Console.WriteLine("please enjoy!");
        }
    }
}
