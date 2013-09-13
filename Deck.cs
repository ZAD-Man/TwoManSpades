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
        static Random random = new Random();
        List<Card> cards = new List<Card>();

        public Deck()
        {
            resetDeck();
        }

        public void Shuffle()
        {
            int deckSize = getDeckSize();
            for (int i = 0; i < deckSize; i++)
            {
                int newPosition = random.Next(deckSize);
                Card tempCard = cards.ElementAt(i);
                cards.RemoveAt(i);
                cards.Insert(i, cards.ElementAt(newPosition));
                cards.RemoveAt(newPosition);
                cards.Insert(newPosition, tempCard);
            }
        }

        public Card Draw()
        {
            Card drawnCard = cards.ElementAtOrDefault(0);
            cards.RemoveAt(0);
            return drawnCard;
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public int getDeckSize()
        {
            return cards.Count;
        }

        public void resetDeck()
        {
            cards.RemoveRange(0, cards.Count);
            foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
            {
                foreach (CardValue value in Enum.GetValues(typeof(CardValue)))
                {
                    AddCard(new Card(suit, value));
                }
            }
        }

    }
}
