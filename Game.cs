using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoManSpades
{
    class Game
    {
        const int NUMBER_OF_PLAYERS = 2;
        
        List<Player> players;
        Deck deck = new Deck();

        public void Start()
        {
            setupPlayers();
        }

        private void setupPlayers()
        {
            for (int i = 0; i < NUMBER_OF_PLAYERS; i++)
            {
                Console.WriteLine("What is Player " + (i+1) + "'s name?");
                String name = Console.ReadLine();
                Player player = new Player(name);
                players.Add(player);
            }
        }
    }
}
