namespace Tschigg
{
    public class Tschigg
    {
        List<Dice>? dices;

        // Create Dices
        public void Setup()
        {
            dices = new List<Dice>{new Dice(),new Dice(),new Dice()};
        }

        // Roll the Dices
        public void PlayRound()
        {
            dices?.ForEach(d => d.Throw());
            saveDice();
        }

        // Check fot Tschigg
        public bool isTschigg()
        {
            if (dices!.All(x => x?.Value == 1))
            {
                return true;
            }

            return false;
        }

        // Save the good dices
        private void saveDice()
        {
            // Check for a one and prevent rethrow
            foreach (var dice in dices!)
            {
                if (dice.Value == 1)
                {
                    dice.isSaved = true;
                }
            }

            // Save double six as a one
            if (dices[0]?.Value == 6 && dices[1]?.Value == 6)
            {
                dices[0].Value = 1;
                dices[0].isSaved = true;
                return;
            }

            if (dices[0]?.Value == 6 && dices[2]?.Value == 6)
            {
                dices[0].Value = 1;
                dices[0].isSaved = true;
                return;
            }

            if (dices[1]?.Value == 6 && dices[2]?.Value == 6)
            {
                dices[1].Value = 1;
                dices[1].isSaved = true;
                return;
            }
        }
    }
}


