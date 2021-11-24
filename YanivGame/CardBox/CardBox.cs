using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardLibrary;

namespace CardBox
{
    /// <summary>
    /// Элемент управления для отображения карт
    /// </summary>
    public partial class CardBox : UserControl
    {
        /// <summary>
        /// Свойство карты: устанавливает / получает базовый объект карты.
        /// </summary>
        private Card myCard;
        public bool onTable = false;
        public Card Card
        {
            set
            {
                myCard = value;
                UpdateCardImage();
            }
            get { return myCard; }
        }


        /// <summary>
        /// Свойство Suit: устанавливает / получает костюм соответствующего объекта Card.
        /// </summary>
        public Suit Suit
        {
            set
            {
                Card.Suit = value;
                UpdateCardImage();
            }
            get { return Card.Suit; }
        }


        /// <summary>
        /// Свойство Rank: устанавливает / получает ранг базового объекта карты.
        /// </summary>
        public Rank Rank
        {
            set
            {
                Card.Rank = value;
                UpdateCardImage();
            }
            get { return Card.Rank; }
        }

        /// <summary>
        /// Свойство FaceUp: устанавливает / получает свойство FaceUp базового объекта Card.
        /// </summary>
        public bool FaceUp
        {
            set
            {
                // Если значение отличается от основной карты
                if (myCard.FaceUp != value)
                {
                    myCard.FaceUp = value;

                    UpdateCardImage();

                    if (CardFlipped != null)
                    {
                        CardFlipped(this, new EventArgs());
                    }
                }
            }
            get { return Card.FaceUp; }
        }
        private Orientation myOrientation;
        public Orientation CardOrientation
        {
            set
            {
                if (myOrientation != value)
                {
                    myOrientation = value;
                    this.Size = new Size(Size.Height, Size.Width);
                    UpdateCardImage();
                }
            }
            get { return myOrientation; }
        }
        /// <summary>
        /// UpdateCardImage Helper Method
        /// Устанавливает изображение PictureBox
        /// </summary>
        private void UpdateCardImage()
        {
            // Установить изображение
            pbPictureBox.Image = myCard.GetCardImage();

            if (myOrientation == Orientation.Horizontal)
            {
                // Повернуть изображение
                pbPictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
        }

        /// <summary>
        /// Constructor
        /// Создает управление с новой картой, ориентированной вертикально.
        /// </summary>
        public CardBox()
        {
            InitializeComponent();
            myOrientation = Orientation.Vertical;
            myCard = new Card();
        }


        /// <summary>
        /// Constructor (Card, Orientation)
        /// Создает элемент управления с использованием параметризованного конструктора.
        /// </summary>
        /// <param name="card"></param>
        /// <param name="orientation"></param>
        public CardBox(Card card, Orientation orientation = Orientation.Vertical)
        {
            InitializeComponent();
            myOrientation = orientation;
            myCard = card;
        }

        /// <summary>
        /// Обработчик события для события загрузки.
        /// </summary>
        private void CardBox_Load(object sender, EventArgs e)
        {
            UpdateCardImage();
        }

        public event EventHandler CardFlipped;
        new public event EventHandler Click;

        /// <summary>
        /// Обработчик событий для пользователя, щелкающего по элементу управления.
        /// </summary>
        private void pbPictureBox_Click(object sender, EventArgs e)
        {
            // Если есть обработчик для нажатия на элемент управления
            if (Click != null)
            {
                Click(this, e);
            }
        }
        /// <summary>
        /// ToString
        /// Overrides the System.Object.ToString().
        /// </summary>
        /// <returns>название карты в виде строки</returns>
        public override string ToString()
        {
            return myCard.ToString();
        }
    }
}

