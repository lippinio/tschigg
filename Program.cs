namespace Tschigg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Setup Counters
            int firstThrowTschiggs = 0;
            int secondThrowTschigg = 0;
            int thirdThrowTschiggs = 0;
            int maxIterations = 100_000_000;

            //Simulate Games
            for (int i = 0; i < maxIterations; i++)
            {
                var tschigg = new Tschigg();
                tschigg.Setup();
                // Play first round
                tschigg.PlayRound();
                if (tschigg.isTschigg())
                {firstThrowTschiggs++;}
                else
                {
                    // Play second round
                    tschigg.PlayRound();
                    if (tschigg.isTschigg()) { secondThrowTschigg++; }
                    else
                    {
                        // Play third round
                        tschigg.PlayRound();
                        if (tschigg.isTschigg()) { thirdThrowTschiggs++; };
                    }
                }
            }

            //Print summary
            Console.WriteLine($"Handtschiggs: {(decimal)firstThrowTschiggs / maxIterations * 100}%");
            Console.WriteLine($"Tschiggs im Zweiten Wurf: {(decimal)secondThrowTschigg / maxIterations * 100}%");
            Console.WriteLine($"Tschiggs im Dritten Wurf: {(decimal)thirdThrowTschiggs / maxIterations * 100}%");
            Console.WriteLine($"Total Tschiggs: {(decimal)(firstThrowTschiggs + secondThrowTschigg + thirdThrowTschiggs) / maxIterations * 100}%");
        }
    }
}


