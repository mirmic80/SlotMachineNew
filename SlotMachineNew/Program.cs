namespace SlotMachineNew
{
    internal class Program
    {
        static void Main(string[] arg)
        {
            UserInterface.DisplayWelcomeScreen();
            bool playing = true;
            int coins = 30; //always start with 30 coins
            int width = 3;
            int length = 3;

            while (playing)
            {
                int[][] randomNumbers = GenerateRandomNuumberGrid(width, length);
                int compareHorizontal = SetNumberHorizontal(randomNumbers);
                int compareVertical = SetNumberVertical(randomNumbers);
                coins = coins + CalculationCoins(compareHorizontal, compareVertical);
                playing = ConsolInfo(playing);

                if (playing == false)
                {
                    UserInterface.OutMeasage(coins);
                    break;
                }
                if (coins <= 0)
                {
                    UserInterface.NoMoreCoins();
                    break;
                }

                UserInterface.CoinsLeft(coins);
                UserInterface.DisplaySlotMachineState(randomNumbers); //displays nice grid
                UserInterface.MeasageWinOrLose(compareHorizontal, compareVertical);
            }

        }

        /// <summary>
        /// checks the keyboard input
        /// </summary>
        /// <param name="buttons">compares the keyboard input</param>
        /// <returns>is the keyboard input correct</returns>
        static bool ConsolInfo(bool buttons)
        {
            ConsoleKeyInfo info = Console.ReadKey(true);
            if (info.Key != ConsoleKey.Escape)
            {
                buttons = true;
            }
            if (info.Key == ConsoleKey.Escape)
            {
                buttons = false;
            }
            return buttons;
        }

        /// <summary>
        /// calculates the win or loss
        /// </summary>
        /// <param name="countHorizontal">number of correct horizontal</param>
        /// <param name="countVertical">number of correct vertica</param>
        /// <returns>how much you win or lose</returns>
        static int CalculationCoins(int countHorizontal, int countVertical)
        {
            if (countHorizontal == 0 && countVertical == 0)
                return -10;

            return countHorizontal + countVertical;

        }

        /// <summary>
        /// check the horizontal numbers
        /// </summary>
        /// <param name="gridNumber">generated random number</param>
        /// <returns>number of correct horizontal lines</returns>
        static int SetNumberHorizontal(int[][] gridNumber)
        {
            int returnCoins = 0;
            for (int i = 0; i < gridNumber.Length; i++)
            {
                int comapreNumberHorizontal = 0;
                for (int j = 0; j < gridNumber[i].Length - 1; j++)
                {
                    if (gridNumber[i][0] == gridNumber[i][j + 1])
                    {
                        comapreNumberHorizontal++;
                    }
                }
                if (comapreNumberHorizontal == gridNumber[i].Length - 1)
                    returnCoins += 5;
            }
            return returnCoins;
        }

        /// <summary>
        /// check the vertivcal numbers
        /// </summary>
        /// <param name="gridNumber">generated random number</param>
        /// <returns>number of correct vertical lines</returns>
        static int SetNumberVertical(int[][] gridNumber)
        {
            int returnCoins = 0;
            for (int i = 0; i < gridNumber[0].Length; i++)
            {
                int comapreNumberVertical = 0;
                for (int j = 0; j < gridNumber.Length - 1; j++)
                {
                    if (gridNumber[0][i] == gridNumber[j + 1][i])
                    {
                        comapreNumberVertical++;
                    }
                }

                if (comapreNumberVertical == gridNumber.Length - 1)
                    returnCoins += 5;
            }
            return returnCoins;

        }

        /// <summary>
        /// creates an array with random number
        /// </summary>
        /// <param name="rawDimension">length of the array is int width</param>
        /// <param name="lenghtDimension">length of the array is int length</param>
        /// <returns>random number</returns>
        static int[][] GenerateRandomNuumberGrid(int rawDimension, int lenghtDimension)
        {
            int[][] raw = new int[rawDimension][];
            for (int i = 0; i < rawDimension; i++)
            {
                raw[i] = new int[lenghtDimension];
            }
            for (int i = 0; i < rawDimension; i++)
            {
                for (int j = 0; j < lenghtDimension; j++)
                {
                    Random rng = new Random();
                    int lucky = rng.Next(0, 5);
                    raw[i][j] = lucky;
                }
            }
            return raw;
        }
    }
}
