using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("Welcome to the slotmachint");
        }

    }
}