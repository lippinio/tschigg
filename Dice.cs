namespace Tschigg
{
    internal class Dice
    {
        static Random random = new Random();

        public bool isSaved = false;
        public int Value;

        // Roll activ dice
        public void Throw()
        {
            if (isSaved)
            {
                return;
            }
            Value = random.Next(1, 7);
        }
    }
}


