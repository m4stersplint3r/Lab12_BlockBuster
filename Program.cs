using System;
using System.Collections.Generic;

namespace Day12_Blockbuster
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuChoice;
            string newMovieYN = "y";
            string watchMovieYN;
            string continueWatchingYN;
            List<Movie> moviesCheckedOut = new List<Movie>();
            Blockbuster bb = new Blockbuster();
            Movie checkedMovie;

            while (newMovieYN == "y")
            {
                Console.Clear();

                Console.WriteLine("Welcome to Blockbuster Video!");
                Console.WriteLine();
                checkedMovie = bb.CheckOut();
                moviesCheckedOut.Add(checkedMovie);
                Console.WriteLine();
                Console.Write("Do you want to watch the movie? (y or n): ");
                watchMovieYN = Console.ReadLine().Trim().ToLower();
                while(watchMovieYN != "y" && watchMovieYN != "n")
                {
                    Console.Write("You must enter y or n: ");
                    newMovieYN = Console.ReadLine();
                }
                
                if (watchMovieYN == "y")
                {
                    Console.WriteLine($"{Environment.NewLine}Please choose an option:");
                    Console.WriteLine($"1. Play all of {checkedMovie.Title}");
                    Console.WriteLine($"2. Choose a scene from {checkedMovie.Title}{Environment.NewLine}");
                    Console.Write("Choose: ");

                    while (int.TryParse(Console.ReadLine().Trim(), out menuChoice) == false || (menuChoice != 1 && menuChoice != 2))
                    {
                        Console.Write($"You must enter 1 or 2: ");
                    }
                    if(menuChoice == 1)
                    {
                        checkedMovie.PlayWholeMovie();
                    }
                    else if(menuChoice == 2)
                    {
                        do
                        {
                            checkedMovie.Play();
                            Console.Write("Watch another scene? (y or n): ");
                            continueWatchingYN = Console.ReadLine().Trim().ToLower();
                            while (continueWatchingYN != "y" && continueWatchingYN != "n")
                            {
                                Console.Write("You must enter y or n: ");
                                continueWatchingYN = Console.ReadLine();
                            }
                        } while (continueWatchingYN == "y");
                    }                    
                }

                Console.Write($"{Environment.NewLine}Would you like to pick another movie? (y or n): ");
                newMovieYN = Console.ReadLine().Trim().ToLower();
                while(newMovieYN != "y" && newMovieYN != "n")
                {
                    Console.Write("You must enter y or n: ");
                    newMovieYN = Console.ReadLine();
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
