using System.Runtime.Versioning;

namespace LastMileBowlingKata {
    public class Game
    {
        private Frame[] frames = new Frame[10];

        public Game()
        {
            
        }

        public int getNumberOfFrames() 
        {
            return frames.Length;
        }
    }
}