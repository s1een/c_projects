using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CardLibrary
{
    public class Card : ICloneable
    {
        public readonly Rank rank;
        public readonly Suit suit;
        public bool onTable = false;
        /// <summary>
        /// Suit Property
        /// Получить или изменить масть карты
        /// </summary>
        protected Suit mySuit;
        public Suit Suit
        {
            // Return suit
            get { return mySuit; }
            // Set suit
            set { mySuit = value; }
        }

        /// <summary>
        /// Rank Property
        /// Получить или изменить ранг карты
        /// </summary>
        protected Rank myRank;
        public Rank Rank
        {
            get { return myRank; }
            set { myRank = value; }
        }

        /// <summary>
        /// CardValue Property
        /// Получить или изменить значение карты
        /// </summary>
        protected int myValue;
        public int CardValue
        {
            get { return myValue; }
            set { myValue = value; }
        }

        /// <summary>
        /// Alternate Value Property
        /// </summary>
        protected int? altValue = null;
        public int? AlternateValue
        {
            get { return altValue; }
            set { altValue = value; }
        }

        /// <summary>
        /// FaceUp Property
        /// Получить или установить перевернута ли карта
        /// Set to false by default
        /// </summary>
        protected bool faceUp = false;
        public bool FaceUp
        {
            get { return faceUp; }
            set { faceUp = value; }
        }
        /// <summary>
        /// Card Constructor
        /// Создание карты
        /// </summary>
        /// <param name="rank">Ранг карты</param>
        /// <param name="suit">Масть карты</param>
        public Card(Rank newRank, Suit newSuit)
        {
            rank = newRank;
            suit = newSuit;
        }
        /// <summary>
        /// Пустой конструктор
        /// </summary>
        public Card()
        {
        }
        /// <summary>
        /// Работа с козырем(для усовершенствования игры)
        /// than cards of other suits.
        /// </summary>
        public static bool useTrumps = false;

        /// <summary>
        /// Работа с козырем(для усовершенствования игры)
        /// </summary>
        public static Suit trump = Suit.Clubs;

        /// <summary>
        /// Дебаг
        /// than deuces.
        /// </summary>
        public static bool isAceHigh = true;
        /// <summary>
        /// CompareTo Method
        /// Сортировка экземпляров карты
        /// </summary>
        /// <param name="obj">Объект с которым сравнивается карта.</param>
        /// <returns>Целое число, которое указывает, предшествует ли эта карта, следует или встречается в сортировке.</returns>
        public virtual int CompareTo(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("Unable to compare a Card to a null object");
            }

            Card compareCard = obj as Card;

            if (compareCard != null)
            {
                int thisSort = this.myValue * 10 + (int)this.mySuit;
                int compareCardSort = compareCard.myValue * 10 + (int)compareCard.mySuit;

                return (thisSort.CompareTo(compareCardSort));
            }
            else
            {
                throw new ArgumentException("Object being compared cannot be converted to a Card.");
            }
        }
        /// <summary>
        /// Clone Method
        /// Для поддержки интерфейса ICloneable.
        /// </summary>
        /// <returns>Копия карты как System.Object</returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        /// <summary>
        /// ToString: Overrides System.Object.ToString()
        /// </summary>
        /// <returns>Название карты в виде строки</returns>
        public override string ToString()
        {
            string cardString;

            if (faceUp)
            {
                cardString = myRank.ToString() + " of " + mySuit.ToString();
            }
            else
            {
                cardString = "Face Down";
            }

            return cardString;
        }
        /// <summary>
        /// Equals: Overrides System.Object.Equals()
        /// </summary>
        /// <returns>true, если значения карты равны</returns>
        public override bool Equals(object obj)
        {
            return (this.CardValue == ((Card)obj).CardValue);
        }
        /// <summary>
        /// GetHashCode: Overrides System.Object.GetHashCode()
        /// </summary>
        /// <returns>Card value * 10 + Suit number</returns>
        public override int GetHashCode()
        {
            return this.myValue * 100 + (int)this.mySuit * 10 + ((this.faceUp) ? 1 : 0);
        }
        public Image GetCardImage()
        {
            string imageName;
            Image cardImage;

            if (!faceUp)
            {
                imageName = "_card_back";
            }
            else
            {
                imageName = mySuit.ToString() + "_" + myRank.ToString();
            }
            cardImage = Properties.Resources.ResourceManager.GetObject(imageName) as Image;
            return cardImage;
        }
        /// <summary>
        /// DebugString
        /// Создает строку, отображающую состояние объекта карты.
        /// </summary>
        /// <returns>строка, показывающая состояние объекта карты</returns>
        public string DebugString()
        {
            string cardState = (string)(myRank.ToString() + " of " + mySuit.ToString().PadLeft(20));
            cardState += (string)((FaceUp) ? "(Face Up)" : "(Face Down)").PadLeft(12);
            cardState += " Value: " + myValue.ToString().PadLeft(2);
            cardState += ((altValue != null) ? "/" + altValue.ToString() : "");
            return cardState;
        }
        // Сравнение карт
        public static bool operator ==(Card left, Card right)
        {
            return (left.suit == right.suit) && (left.rank == right.rank);
        }

        public static bool operator !=(Card left, Card right)
        {
            return !(left == right);
        }

        public static bool operator <(Card left, Card right)
        {
            return !(left >= right);
        }

        public static bool operator <=(Card left, Card right)
        {
            return !(left > right);
        }

        public static bool operator >(Card left, Card right)
        {
            if (left.suit == right.suit)
            {
                if (isAceHigh)
                {
                    if (left.rank == Rank.Ace)
                    {
                        if (right.rank == Rank.Ace)
                            return false;
                        else
                            return true;
                    }
                    else
                    {
                        if (right.rank == Rank.Ace)
                            return false;
                        else
                            return (left.rank > right.rank);
                    }
                }
                else
                {
                    return (left.rank > right.rank);
                }
            }
            else
            {
                if (useTrumps && (right.suit == Card.trump))
                    return false;
                else
                    return true;
            }
        }

        public static bool operator >=(Card left, Card right)
        {
            if (left.suit == right.suit)
            {
                if (isAceHigh)
                {
                    if (left.rank == Rank.Ace)
                    {
                        return true;
                    }
                    else
                    {
                        if (right.rank == Rank.Ace)
                            return false;
                        else
                            return (left.rank >= right.rank);
                    }
                }
                else
                {
                    return (left.rank >= right.rank);
                }
            }
            else
            {
                if (useTrumps && (right.suit == Card.trump))
                    return false;
                else
                    return true;
            }
        }

    }
}
