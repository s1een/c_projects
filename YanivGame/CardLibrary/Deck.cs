using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLibrary
{
    public class Deck : ICloneable
    {
        public event EventHandler LastCardDrawn;

        private Cards cards = new Cards();

        public Deck()
        {
            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                for (int rankVal = 1; rankVal < 13; rankVal++)
                {
                    cards.Add(new Card((Rank)rankVal, (Suit)suitVal));
                }
            }
        }

        private Deck(Cards newCards)
        {
            cards = newCards;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Deck(bool isAceHigh)
           : this()
        {
            Card.isAceHigh = isAceHigh;
        }
        /// <summary>
        /// Выдать карту
        /// </summary>
        /// <param name="cardNum">Номер карты в колоде</param>
        /// <returns></returns>
        public Card GetCard(int cardNum)
        {
            if (cardNum >= 0 && cardNum <= 51)
            {
                if ((cardNum == 51) && (LastCardDrawn != null))
                    LastCardDrawn(this, EventArgs.Empty);
                return cards[cardNum];
            }
            else
                throw new CardOutOfRangeException(cards.Clone() as Cards);
        }
        /// <summary>
        /// Перемешать карты
        /// </summary>
        public void Shuffle()
        {
            Cards newDeck = new Cards();
            bool[] assigned = new bool[52];
            Random sourceGen = new Random();
            for (int i = 0; i < 52; i++)
            {
                int sourceCard = 0;
                bool foundCard = false;
                while (foundCard == false)
                {
                    sourceCard = sourceGen.Next(52);
                    if (assigned[sourceCard] == false)
                        foundCard = true;
                }
                assigned[sourceCard] = true;
                newDeck.Add(cards[sourceCard]);
            }
            newDeck.CopyTo(cards);
        }
        // Создание 2 колоды
        public object Clone()
        {
            Deck newDeck = new Deck(cards.Clone() as Cards);
            return newDeck;
        }
    }
}
