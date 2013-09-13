using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoManSpades
{
    class Game
    {
        private const int NUMBER_OF_PLAYERS = 2;
        private const int SCORE_TO_WIN = 500;

        private List<Player> players;
        private Deck deck = new Deck();

        public void Start()
        {
            SetupPlayers();
        }

        private void SetupPlayers()
        {
            for (int i = 0; i < NUMBER_OF_PLAYERS; i++)
            {
                Console.WriteLine("What is Player " + (i + 1) + "'s name?");
                String name = Console.ReadLine();
                Player player = new Player(name);
                players.Add(player);
            }
        }

        private bool IsGameOver()
        {
            bool gameIsOver = false;
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].Score >= SCORE_TO_WIN)
                {
                    gameIsOver = true;
                    for (int j = 0; j < players.Count; j++)
                    {
                        if (i != j && players[i].Score == players[j].Score)
                        {
                            gameIsOver = false;
                        }
                    }
                }
            }
            return gameIsOver;
        }
    }
}