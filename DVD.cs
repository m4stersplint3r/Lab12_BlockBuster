using System;
using System.Collections.Generic;
using System.Text;

namespace Day12_Blockbuster
{
    class DVD : Movie
    {
        public DVD(string Title, Genre Category, int RunTime, List<string> Scenes)
            :base(Title, Category, RunTime, Scenes)
        {

        }
        public override void Play()
        {
            int sceneChoice = 0;
            
            Console.WriteLine("Which scene would you like to watch?");
            Console.Write($"Enter a scene number: 0 - {Scenes.Count}: ");
            while(int.TryParse(Console.ReadLine().Trim(), out sceneChoice) == false)
            {
                Console.Write($"You must enter 1 - {Scenes.Count}: ");
            }
            string scene = this.Scenes[sceneChoice];
            Console.WriteLine($"Scene {sceneChoice}: {scene}");
        }
        
    }
}
