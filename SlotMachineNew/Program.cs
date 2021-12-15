using SlotMachineNew;
UserInterface.DisplayWelcomeScreen();
bool playing = true;
int coins = 30;
int width = 3;
int length = 3;

while (playing)
{


    int[][] randomNumbers = GenerateRandomNuumberGrid(width, length);
    int compareHorizontal = SetNumberHorizontal(randomNumbers);
    int compareVertical = SetNumberVertical(randomNumbers);
    coins = coins + CalculationCoins(compareHorizontal, compareVertical);
    ConsoleKeyInfo info = Console.ReadKey(true);
    if (info.Key != ConsoleKey.Escape)
    {
        playing = true;
    }
    if (info.Key == ConsoleKey.Escape)
    {
        playing = false;
        UserInterface.OutMeasage(coins);
        break;
    }
    if (coins <= 0)
    {
        UserInterface.NoMoreCoins(coins);
        break;
    }
    Console.Clear();
    UserInterface.NoMoreCoins(coins);
    UserInterface.CoinsLeft(coins);
    UserInterface.DisplaySlotMachineState(randomNumbers); //displays nice grid
    UserInterface.MeasageWinOrLose(coins, coins);

    static int CalculationCoins(int countHorizontal, int countVertical)
    {
        if (countHorizontal == 0 && countVertical == 0)
            return -10;

        return countHorizontal + countVertical;

    }

    static int SetNumberHorizontal(int[][] gridNumber)
    {
        int comapreNumberHorizontal = 0;
        int returnCoins = 0;
        for (int i = 0; i < gridNumber.Length; i++)
        {
            for (int j = 0; j < gridNumber[i].Length - 1; j++)
            {
                if (gridNumber[i][j + 1] == gridNumber[i][0])
                {
                    comapreNumberHorizontal++;
                }
            }
            if (comapreNumberHorizontal == gridNumber.Length - 1)
                returnCoins = 5;
        }
        return returnCoins;
    }

    static int SetNumberVertical(int[][] gridNumber)
    {
        int comapreNumberVertical = 0;
        int returnCoins = 0;
        for (int i = 0; i < gridNumber[0].Length; i++)
        {
            for (int j = 0; j < gridNumber.Length - 1; j++)
            {
                if (gridNumber[j + 1][i] == gridNumber[0][i])
                {
                    comapreNumberVertical++;
                }
            }

            if (comapreNumberVertical == gridNumber[i].Length - 1)
                returnCoins = 5;
        }
        return returnCoins;

    }
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
                int lucky = rng.Next(0, 9);
                raw[i][j] = lucky;
            }
        }
        return raw;
    }
}