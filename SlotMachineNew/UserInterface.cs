namespace SlotMachineNew
{
    public static class UserInterface
    {
        /// <summary>
        /// output of the random number
        /// </summary>
        /// <param name="state">random number</param>
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

        /// <summary>
        /// start information with how many coins
        /// </summary>
        public static void DisplayWelcomeScreen()
        {
            Console.WriteLine("Press any key to start,(ESC) to exit/playout. You start with 30 Coins");
        }

        /// <summary>
        /// delete the before information with issue how many coins current
        /// </summary>
        /// <param name="coins">calculated coins</param>
        public static void CoinsLeft(int coins)
        {
            Console.Clear();
            Console.WriteLine("**************");
            Console.WriteLine("Coins Left: " + coins);
            Console.WriteLine("**************");
        }

        /// <summary>
        /// how many coins when exiting
        /// </summary>
        /// <param name="winCoins">calculated coins</param>
        public static void OutMeasage(int winCoins)
        {
            Console.Clear();
            Console.WriteLine("PLAYOUT! You got " + winCoins + " Coins");

        }

        /// <summary>
        /// ouput win or lose
        /// </summary>
        /// <param name="winHorizontal">compare horizontal</param>
        /// <param name="winVertical">compare vertical</param>
        public static void MeasageWinOrLose(int winHorizontal, int winVertical)
        {
            if (winHorizontal != 0 || winVertical != 0)
            {
                Console.WriteLine("You win");
            }
            else
            {
                Console.WriteLine("You lose");
            }
        }

        /// <summary>
        /// output when no coins are available
        /// </summary>
        public static void NoMoreCoins()
        {
            Console.Clear();
            Console.WriteLine("You have lost");
        }

        /// <summary>
        /// checks the keyboard input
        /// </summary>
        /// <returns>is the keyboard input correct then abort</returns>
        public static bool ConsoleInfo()
        {
            bool run = false;
            ConsoleKeyInfo info = Console.ReadKey(true);
            if (info.Key != ConsoleKey.Escape)
            {
                run = true;
            }
            if (info.Key == ConsoleKey.Escape)
            {
                run = false;
            }
            return run;
        }
    }
}