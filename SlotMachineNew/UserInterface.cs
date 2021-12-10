namespace SlotMachineNew
{
    public static class UserInterface
    {
        public static void DisplaySlotMachineState(int[][] state)
        {
            for (int i = 0; i < state.Length; i++)
            {
                for (int j = 0; j < state.Length; j++)
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
    }
}