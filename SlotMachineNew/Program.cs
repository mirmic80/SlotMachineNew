using SlotMachineNew;


UserInterface.DisplayWelcomeScreen();
bool playing = true;
int startCoins = 30;

while (playing)
{

    int width = 3;
    int length =3;
    int[][] randomNumbers = GenerateRandomNuumberGrid(width, length);
    int compareHorizontal = CompareGridNumberHorizontal(randomNumbers);
    int compareVertical = CompareGridNumberVertical(randomNumbers);
    int playCoins = CalculationCoins(compareHorizontal, compareVertical, startCoins);

    ConsoleKeyInfo info = Console.ReadKey(true);
    if (info.Key != ConsoleKey.Escape)
    {
        playing = true;
    }

    if (info.Key == ConsoleKey.Escape)
    {
        playing = false;
        UserInterface.OutMeasage(playCoins);
        break;
    }

    if (playCoins <= 0)
    {
        UserInterface.NoMoreCoins(playCoins);
        break;
    }
    Console.Clear();

    UserInterface.NoMoreCoins(playCoins);
    UserInterface.CoinsLeft(playCoins);
    UserInterface.DisplaySlotMachineState(randomNumbers); //displays nice grid
    UserInterface.MeasageWinOrLose(startCoins, playCoins);

    startCoins = playCoins;
    static int CalculationCoins(int countHorizontal, int countVertical, int coins)
    {
        if (countHorizontal == 0 && countVertical == 0)
        {
            coins = coins - 10;
        }
        else
        {
            if (countHorizontal >= 0)
            {
                coins = countHorizontal + coins;
            }
            if (countVertical >= 0)
            {
                coins = countVertical + coins;
            }
        }
        return coins;
    }

    static int CompareGridNumberHorizontal(int[][] gridNumber)
    {
        int comapreNumberHorizontal = 0;
        for (int i = 0; i < gridNumber.Length; i++)
        {
            for (int j = 0; j < gridNumber[i].Length - 1; j++)
            {
                if (gridNumber[i][j + 1] == gridNumber[i][0])
                {
                    comapreNumberHorizontal++;
                }
            }
        }
        return comapreNumberHorizontal;
    }

    static int CompareGridNumberVertical(int[][] gridNumber)
    {
        int comapreNumberVertical = 0;
        for (int i = 0; i < gridNumber[0].Length; i++)
        {            
            for (int j = 0; j < gridNumber.Length-1; j++)                
            {                
                if (gridNumber[j+1][i] == gridNumber[0][i])                    
                {                    
                    comapreNumberVertical++;
                }
            }
        }
        return comapreNumberVertical;
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