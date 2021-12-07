using SlotMachineNew;


UserInterface.DisplayWelcomeScreen();

int width = 3;
int length = 3;


int[][] randomNumbers = GenerateRandomNuumberGrid(width, length);
int compareHorizontal = CompareGridNumberHorizontal(randomNumbers);
int compareVertical = CompareGridNumberVertical(randomNumbers);

UserInterface.DisplaySlotMachineState(randomNumbers); //displays nice grid

for (int i = 0; i < width; i++)
{
    for (int j = 0; j < length; j++)
    {
        Console.Write(randomNumbers[i][j]);
    }
    Console.WriteLine();
}

static int CompareGridNumberHorizontal(int[][] gridNumber)
{
    int comapreNumberHorizontal = 0;
    for(int i = 0;i < gridNumber.Length;i++)
    {
        for (int j = 0;j < gridNumber[i].Length;j++)
        {
            if (gridNumber[i][j] == gridNumber[i][0])
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
        for (int j = 0; j < gridNumber.Length; j++)
        {
            if (gridNumber[i][j] == gridNumber[i][0])
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
            int lucky = rng.Next(0, 3);
            raw[i][j] = lucky;
        }
    }
    return raw;
}



