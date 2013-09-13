using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoManSpades
{
    class Hand
    {
        List<Card> cards = new List<Card>();

        public void addCard(Card card)
        {
            cards.Add(card);
            Sort();
        }

        private void Sort()
        {
            for (int i = 2; i < cards.Count; i++) //Insertion Sort
            {
                for (int k = 0; k > 1 && cards[k].getCardSorterValue() < cards[k - 1].getCardSorterValue(); k--)
                {
                    Card tempCard = cards[k];
                    cards[k] = cards[k - 1];
                    cards[k - 1] = tempCard;
                }
            }
        }
    }
}
