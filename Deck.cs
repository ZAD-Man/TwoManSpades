using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoManSpades
{
    class Deck
    {
        private static Random _random = new Random();
        private List<Card> _cards = new List<Card>();

        public Deck()
        {
            ResetDeck();
        }

        public void Shuffle()
        {
            int deckSize = GetDeckSize();
            for (int i = 0; i < deckSize; i++)
            {
                int newPosition = _random.Next(deckSize);
                Card tempCard = _cards[i];
                _cards.RemoveAt(i);
                _cards.Insert(i, _cards[newPosition]);
                _cards.RemoveAt(newPosition);
                _cards.Insert(newPosition, tempCard);
            }
        }

        public Card Draw()
        {
            Card drawnCard = _cards.ElementAtOrDefault(0);
            _cards.RemoveAt(0);
            return drawnCard;
        }

        public void AddCard(Card card)
        {
            _cards.Add(card);
        }

        public int GetDeckSize()
        {
            return _cards.Count;
        }

        public void ResetDeck()
        {
            _cards.RemoveRange(0, _cards.Count);
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