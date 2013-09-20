using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoManSpades
{
    class Player
    {
        public Hand Hand { get; set; }
        public string Name { get; private set; }
        public int Score { get; private set; }
        public int Bid { get; set; }
        public int Bags { get; private set; }
        public bool IsComputer { get; private set; }

        private const int BAGS_TO_ROLL_OVER = 10;
        private const int BAG_PENALTY = 100;

        public Player(string name) : this(name, false)
        {
        }

        public Player(string name, bool isComputer)
        {
            Name = name;
            Score = 0;
            IsComputer = isComputer;
        }

        public void AddBags(int numberOfBags)
        {
            Bags += numberOfBags;
            Score += numberOfBags;

            while (Bags >= BAGS_TO_ROLL_OVER)
            {
                Score -= BAG_PENALTY;
                Score -= BAGS_TO_ROLL_OVER;
                Bags -= BAGS_TO_ROLL_OVER;
            }
        }

        public void ChangeScore(int amountToChange)
        {
            Score += amountToChange;
        }
    }
}