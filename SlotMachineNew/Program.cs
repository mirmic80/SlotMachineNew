

int luckNumberMin = 0;
int luckyNumberMax = 3;
int spinMin = 10;
int spinMax = 100;
int wager = 0;
string input;
bool wantsToPlayGame = true;

Random randomSpin = new Random();
int spinNumber = randomSpin.Next(spinMin, spinMax);

//Declare the array of two elements.
int[][] slotMachineLine = new int[3][];

// Initialize the elements.
slotMachineLine[0] = new int[3];
slotMachineLine[1] = new int[3];
slotMachineLine[2] = new int[3];

while (wantsToPlayGame)
{
    Console.WriteLine("Please your wager");
    input = Console.ReadLine();
    wager = int.Parse(input);

    //for (int z = 0; z < spinNumber; z++)
    //{
        Console.Clear();
        // Display the array elements.
        for (int i = 0; i < slotMachineLine.Length; i++)
        {
            //Fills the random number into the array
            for (int j = 0; j < slotMachineLine[i].Length; j++)
            {
                Random RandomLucky = new Random();
                int luckyNumber = RandomLucky.Next(luckNumberMin, luckyNumberMax);
                slotMachineLine[i][j] = luckyNumber;
                System.Console.Write(slotMachineLine[i][j]);
            }
            Console.WriteLine();
        }
    //}

    //Compares the numbers on the middle row :)
    if (slotMachineLine[1][0] == slotMachineLine[1][1] && slotMachineLine[1][0] == slotMachineLine[1][2])
    {
        Console.WriteLine("Jackpot you are the winner");
    }
    else
    {
        Console.WriteLine("you lost");
    }
    Test();

    Console.WriteLine("press E to exit the game or press another tap for a new game");

    bool correctKey = false;
    while (!correctKey)
    {

        ConsoleKeyInfo info = Console.ReadKey(true);

        if (info.Key != ConsoleKey.E)
        {
            wantsToPlayGame = true;
            correctKey = true;
        }

        if (info.Key == ConsoleKey.E)
        {
            wantsToPlayGame = false;
            correctKey = true;
        }
    }
}

int Test()
{
    return 0;
}


