using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoManSpades
{
    class Program
    {
        private static void Main(string[] args)
        {
            Game game = new Game();
            game.Start();
            Console.WriteLine("Game End");
            Console.ReadLine();
        }
    }
}