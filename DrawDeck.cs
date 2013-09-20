using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoManSpades
{
    class DrawDeck : Deck
    {
        public override Card Draw()
        {
            const int drawnCardPosition = 0;

            Card drawnCard = Cards.ElementAtOrDefault(drawnCardPosition);
            Cards.RemoveAt(drawnCardPosition);
            return drawnCard;
        }

        public override void ResetDeck()
        {
            Cards.RemoveRange(0, Cards.Count - 1);
            foreach (CardSuit suit in Enum.GetValues(typeof (CardSuit)))
            {
                foreach (CardValue value in Enum.GetValues(typeof (CardValue)))
                {
                    AddCard(new Card(suit, value));
                }
            }
        }
    }
}