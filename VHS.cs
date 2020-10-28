using System;
using System.Collections.Generic;
using System.Text;

namespace Day12_Blockbuster
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; }

        public VHS() { }
        public VHS(string Title, Genre Category, int RunTime, List<string> Scenes, int CurrentTime)
            :base(Title, Category, RunTime, Scenes)
        {
            this.CurrentTime = CurrentTime;
        }
        public override void Play()
        {
            // to prevent out of range exception from calling play after scenes reach the end
            if(CurrentTime == Scenes.Count)
            {
                Console.WriteLine("End of movie, rewind started.");
                Rewind();
            }
            string scene = this.Scenes[CurrentTime];
            Console.WriteLine(scene);
            this.CurrentTime += 1;
        }
        public void Rewind()
        {
            this.CurrentTime = 0;
        }
    }
}
