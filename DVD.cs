using System;
using System.Collections.Generic;
using System.Text;

namespace Day12_Blockbuster
{
    class DVD : Movie
    {
        public DVD(string Title, Genre Category, int RunTime, List<string> Scenes)
            :base(Title, Category, RunTime, Scenes) { }
        public override void Play()
        {
            int sceneChoice;
            const int offset = 1;
            
            Console.WriteLine($"Which scene from the DVD {Title} would you like to watch?");
            Console.Write($"Enter a scene number: 0 - {Scenes.Count - offset}: ");
            while(int.TryParse(Console.ReadLine().Trim(), out sceneChoice) == false)
            {
                Console.Write($"You must enter 0 - {Scenes.Count - offset}: ");
            }
            string scene = Scenes[sceneChoice];
            Console.WriteLine($"Scene {sceneChoice}: {scene}");
        }
        
    }
}
