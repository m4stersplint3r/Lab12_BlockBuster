using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace Day12_Blockbuster
{
    class Blockbuster
    {
        const int offset = 1;
        public List<Movie> Movies { get; set; }

        public Blockbuster() {
            List<Movie> movies = new List<Movie>();
            List<string> screamScenes = new List<string>() { "First Phone call", "Dead babysitter", "Scared students",
                "Syd is alone", "Suspecting boyfriend", "Killer revealed", "Killers are dead" };
            List<string> halloweenScenes = new List<string>() { "Kills sister", "Escapes in transport", "Gains jumpsuit and vehicle",
                "Comes home", "Finds Laurie", "Kills her friends", "Loomis Shoots Michael", "Michael is gone" };
            List<string> talladegaScenes = new List<string>() { "Learn to go fast", "Go fast", "Crash",
                "Afraid to go fast", "Overcome fear", "Win"};
            List<string> tMNTScenes = new List<string>() { "Ooze spills on turtles", "Turtles are raised by Rat and taught ninjitsu", "Turtles leave sewers",
                "Turtles are seen fighting", "Shredder assembles Foot Clan", "Raph is taken hostage", "Turtles save Raph", "Turtles defeat Shredder"};
            List<string> bDScenes = new List<string>() { "Brothers get drunk", "Men found dead in alley", "Brothers confess to self defense killings",
                "Brothers team up with friend to kill mobsters", "Killing commences", "The saints are taken hostage and one of them is killed", "The brothers are saved", "Justice is server to head mobster in courtroom"};
            List<string> jWScenes = new List<string>() { "Agressively drive Mustang", "Dog is killed and Mustang stolen", "Weapons gathered",
                "Intel gathered", "Hunt begins", "Lots and lots of people die", "Bastard who killed dog is found and killed", "New dog acquired"};

            movies.Add(new VHS("Scream", Genre.Horror, 110, screamScenes, 0));
            movies.Add(new VHS("Talladega Nights", Genre.Comedy, 95, talladegaScenes, 0));
            movies.Add(new VHS("TMNT", Genre.Action, 85, tMNTScenes, 0));
            movies.Add(new DVD("Halloween", Genre.Horror, 90, halloweenScenes));
            movies.Add(new DVD("Boondock Saints", Genre.Action, 90, bDScenes));
            movies.Add(new DVD("John Wick", Genre.Action, 112, jWScenes));

            Movies = movies;
        }

        public void PrintMovies()
        {
            Console.WriteLine("Please choose from the list of available movies:" + Environment.NewLine);
            for (int i = 0; i < Movies.Count; i++)
            {                
                int listNumber = i + offset;
                string title = Movies[i].Title;
                Console.WriteLine($"{listNumber}: {title}");
            }
            Console.WriteLine();
        }
        public Movie CheckOut()
        {
            int userChoice;
            PrintMovies();

            Console.Write("Select a movie to check out: ");
            while (int.TryParse(Console.ReadLine().Trim(), out userChoice) == false || (userChoice < 1 || userChoice > Movies.Count))
            {
                Console.Write($"You must enter 1 - {Movies.Count}: ");
            }
            Console.WriteLine();
            Movies[userChoice - offset].PrintInfo();
            return Movies[userChoice - offset];
        }
    }
}
