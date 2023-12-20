namespace LastMileBowlingKata
{
    public class Frame
    {

        private int[] tries = new int[2];

        public Frame()
        {

        }

        public int getNumberOfTries()
        {
            return tries.Length;
        }

        public void updateTryOneScore(int scoreToBeAdded)
        {
            tries[0] += scoreToBeAdded;
        }
    }
}