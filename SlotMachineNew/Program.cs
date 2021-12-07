

//int luckNumberMin = 0;
//int luckyNumberMax = 3;
//int spinMin = 10;
//int spinMax = 100;
//int wager = 0;
//string input;
//bool wantsToPlayGame = true;

//Random randomSpin = new Random();
//int spinNumber = randomSpin.Next(spinMin, spinMax);

////Declare the array of arrays (three elements).
//int[][] slotMachineState = new int[3][];

//// Initialize the elements.
//slotMachineState[0] = new int[3];
//slotMachineState[1] = new int[3];
//slotMachineState[2] = new int[3];

//while (wantsToPlayGame)
//{
//    Console.WriteLine("Please your wager");
//    input = Console.ReadLine();
//    wager = int.Parse(input);

//    //for (int z = 0; z < spinNumber; z++)
//    //{
//    Console.Clear();
//    // Display the array elements.
//for (int i = 0; i < slotMachineLine.Length; i++)
//{
//    //Fills the random number into the array
//    for (int j = 0; j < slotMachineLine[i].Length; j++)
//    {
//        Random RandomLucky = new Random();
//        int luckyNumber = RandomLucky.Next(luckNumberMin, luckyNumberMax);
//        slotMachineLine[i][j] = luckyNumber;
//        System.Console.Write(slotMachineLine[i][j]);
//    }
//    Console.WriteLine();
//    }
//    //}

//    Console.WriteLine(NumberSlotmachine);

//    //Compares the numbers on the middle row 
//    if (slotMachineLine[1][0] == slotMachineLine[1][1] && slotMachineLine[1][0] == slotMachineLine[1][2])
//    {
//        Console.WriteLine("Jackpot you are the winner");
//    }
//    else
//    {
//        Console.WriteLine("you lost");
//    }


//    Console.WriteLine("press E to exit the game or press another tap for a new game");

//    bool correctKey = false;
//    while (!correctKey)
//    {

//        ConsoleKeyInfo info = Console.ReadKey(true);

//        if (info.Key != ConsoleKey.E)
//        {
//            wantsToPlayGame = true;
//            correctKey = true;
//        }

//        if (info.Key == ConsoleKey.E)
//        {
//            wantsToPlayGame = false;
//            correctKey = true;
//        }
//    }

//}
int width = 3;
int length = 3;


int[][] randomNumbers = GenerateRandomNuumberGrid(width, length);
int compareHorizontal = CompareGridNumberHorizontal(randomNumbers);
int compareVertical = CompareGridNumberVertical(randomNumbers);

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


void DisplaySlotMachineState(int[][] state)
{
    for (int i = 0; i < state.Length; i++)
    {
        for (int j = 0; j < state.Length; j++)
        {
            Console.Write(state[i][j]);
        }
    }
}

