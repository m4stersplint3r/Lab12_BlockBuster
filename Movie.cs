using System;
using System.Collections.Generic;
using System.Text;

namespace Day12_Blockbuster
{
    abstract class Movie
    {
        public string Title { get; set; }
        public Genre Category { get; set; }
        public int RunTime { get; set; }
        public List<string> Scenes { get; set; }

        public Movie () { }
        public Movie(string Title, Genre Category, int RunTime, List<string> Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = RunTime;
            this.Scenes = Scenes;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"{Title}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Runtime: {RunTime} minutes");
        }
        public void PrintScenes()
        {
            int i = 0;
            foreach (string scene in Scenes)
            {
                Console.WriteLine($"Scene {i}: {scene}");
                i++;
            }
        }
        public abstract void Play();

        // Taking a chance that this will qualify for the Extended Exercise: Create a PlayWholeMovie in both VHS and DVDs to play each scene from start to finish.
        // Since it technically is in both classes, but only written once.
        public void PlayWholeMovie()
        {
            Console.Clear();
            Console.WriteLine($"Starting {Title}{Environment.NewLine}");
            foreach (var scene in Scenes)
            {
                Console.WriteLine(scene);
            }
        }
    }
}
