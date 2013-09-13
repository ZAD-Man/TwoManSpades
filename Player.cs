using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoManSpades
{
    class Player
    {
        Hand Hand { get; set; }
        string Name { get; private set; }
        int Score { get; private set; }
        int Bid { get; set; }
        int Bags { get; private set; }

        const int BAGS_TO_ROLL_OVER = 10;
        const int BAG_PENALTY = 100;

        public Player(string name)
        {
            Name = name;
            Score = 0;
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

        public void changeScore(int amountToChange)
        {
            Score += amountToChange;
        }
    }
}
