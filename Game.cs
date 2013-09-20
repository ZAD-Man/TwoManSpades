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

        private List<Player> _players;
        private Deck _mainDeck;
        private Deck _discardDeck;

        public Game()
        {
            _players = new List<Player>(NUMBER_OF_PLAYERS);
            _mainDeck = new DrawDeck();
            _discardDeck = new DiscardDeck();
        }


        /*
         * Gameflow:
         * Deal
         * Bid
         * Leader card
         * Other card
         * Adjust score
         * 
         */

        public void Start()
        {
            SetupPlayers();
        }


        private void SetupPlayers()
        {
            for (int i = 0; i < NUMBER_OF_PLAYERS; i++)
            {
                Console.WriteLine("What is Player " + (i + 1) + "'s name?");
                var name = Console.ReadLine();
                var player = new Player(name);
                _players.Add(player);
            }
        }

        private void TwoPlayerDeal()
        {
        }

        private bool IsGameOver()
        {
            bool gameIsOver = false;
            for (int i = 0; i < _players.Count; i++)
            {
                if (_players[i].Score >= SCORE_TO_WIN)
                {
                    gameIsOver = true;
                    for (int j = 0; j < _players.Count; j++)
                    {
                        if (i != j && _players[i].Score == _players[j].Score)
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