using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoManSpades
{
    class Card
    {
        private CardSuit Suit { get; set; }
        private CardValue Value { get; set; }

        public Card(CardSuit suit, CardValue value)
        {
            Suit = suit;
            Value = value;
        }

        public double GetCardSorterValue()
        {
            double sorterValue = (double) Suit;
            sorterValue += (double) Value/100d;
            return sorterValue;
        }
    }
}