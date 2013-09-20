using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoManSpades
{
    class Hand
    {
        private List<Card> _cards = new List<Card>();

        public void AddCard(Card card)
        {
            _cards.Add(card);
            Sort();
        }

        private void Sort()
        {
            for (int i = 2; i < _cards.Count; i++) //Insertion Sort
            {
                for (int k = 0; k > 1 && _cards[k].GetCardSorterValue() < _cards[k - 1].GetCardSorterValue(); k--)
                {
                    Card tempCard = _cards[k];
                    _cards[k] = _cards[k - 1];
                    _cards[k - 1] = tempCard;
                }
            }
        }
    }
}