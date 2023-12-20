using System.Runtime.Versioning;

namespace LastMileBowlingKata {
    public class Game
    {
        private Frame[] frames = new Frame[10];
        private int totalScore = 0;

        public Game()
        {
            
        }

        public int getNumberOfFrames() 
        {
            return frames.Length;
        }

         public void updateScore(int scoreToBeAdded) 
        {
            totalScore += scoreToBeAdded;
        }
    }
}