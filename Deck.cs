using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoManSpades
{
    abstract class Deck
    {
        protected static Random Random = new Random();
        protected List<Card> Cards = new List<Card>();

        public void Shuffle()
        {
            int deckSize = GetDeckSize();
            for (int i = 0; i < deckSize; i++)
            {
                int newPosition = Random.Next(deckSize);
                Card tempCard = Cards[i];
                Cards.RemoveAt(i);
                Cards.Insert(i, Cards[newPosition]);
                Cards.RemoveAt(newPosition);
                Cards.Insert(newPosition, tempCard);
            }
        }

        public abstract Card Draw();

        public void AddCard(Card card)
        {
            Cards.Add(card);
        }

        public int GetDeckSize()
        {
            return Cards.Count;
        }

        public abstract void ResetDeck();
    }
}