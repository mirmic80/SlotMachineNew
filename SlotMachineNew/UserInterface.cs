namespace SlotMachineNew
{
    public static class UserInterface
    {
        public static void DisplaySlotMachineState(int[][] state)
        {
            for (int i = 0; i < state.Length; i++)
            {
                for (int j = 0; j < state[i].Length; j++)
                {
                    Console.Write(state[i][j]);
                }
                Console.WriteLine();
            }
        }

        public static void DisplayWelcomeScreen()
        {
            Console.WriteLine("Press any key to start,(ESC) to exit/playout. You start with 30 Coins");
        }
        public static void CoinsLeft(int coins)
        {
            Console.WriteLine("**************");
            Console.WriteLine("Coins Left: " + coins);
            Console.WriteLine("**************");
        }
        public static void OutMeasage(int winCoins)
        {
            Console.Clear();
            Console.WriteLine("PLAYOUT! You got " + winCoins + " Coins");

        }
        public static void MeasageWinOrLose(int coinStart, int coinsPlay)
        {
            if (coinsPlay >= coinStart)
            {
                Console.WriteLine("You win + " + (coinsPlay - coinStart));
            }
            else
            {
                Console.WriteLine("You lose " + (coinsPlay - coinStart));
            }
        }
        public static void NoMoreCoins(int loseCoins)
        {
            Console.Clear();
            Console.WriteLine("You have lost " + loseCoins + " Coins");
        }
    }
}
