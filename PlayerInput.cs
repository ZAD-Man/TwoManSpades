using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoManSpades
{
    static class PlayerInput
    {
        public static int GetIntegerInput()
        {
            int playerInput = 0;
            bool numberEntered = false;
            while (!numberEntered)
            {
               
                String readInput = Console.ReadLine();

                if (int.TryParse(readInput, out playerInput))
                {
                    numberEntered = true;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }
            return playerInput;
        }
    }
}