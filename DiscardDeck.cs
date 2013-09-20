using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoManSpades
{
    class DiscardDeck : Deck
    {
        public override Card Draw()
        {
            int drawnCardPosition = Cards.Count - 1;

            Card drawnCard = Cards.ElementAtOrDefault(drawnCardPosition);
            Cards.RemoveAt(drawnCardPosition);
            return drawnCard;
        }

        public override void ResetDeck()
        {
            Cards.RemoveRange(0, Cards.Count - 1);
        }
    }
}