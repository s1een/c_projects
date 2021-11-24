using MyCardBox;
using DemoCardsLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUIDemo
{

    public partial class frmMainForm : Form
    {
        /// <summary>
        /// Конструктор с правилами игры
        /// </summary>
        public frmMainForm(GameSettings game)
        {
            InitializeComponent();
            Game = game;
        }
        public GameSettings Game { get; set; }
        /// <summary>
        /// Количество, которое контролирует CardBox, увеличивается при наведении курсора.
        /// </summary>
        private const int POP = 25;
        // Определение победителя в игре
        private bool isWinner = false;
        // Счет за всю игру
        private int p_main_score = 0;
        private int ai_main_score = 0;
        // Счет игрока
        private int Player_score = 0;
        // Состояние ИИ
        private bool ai_turn = true;
        // Счет ИИ
        private int AI_score = 0;
        // Кнопка Show нажата
        private bool show_s = false;
        // Комбинация по значению,масти
        private bool combo_Value = false, combo_suit = false;
        bool take_from_pile = false;
        // Коллекция для карт находящихся на поле
        List<CardBox> collect = new List<CardBox>();
        // Коллекция для карт на руках у ИИ
        List<CardBox> ai_cards = new List<CardBox>();
        // Коллекция комбинаций AI 
        List<CardBox> ai_combo = new List<CardBox>();
        // Отбой
        List<CardBox> discard_pile = new List<CardBox>();
        // Отбой
        List<CardBox> players_cards = new List<CardBox>();
        //  private int l_point,w_point = 0;
        /// <summary>
        /// Дефолтный размер
        /// </summary>
        static private Size regularSize = new Size(75, 107);
        /// <summary>
        /// Используется для создания объектов Card из колоды
        /// </summary>
        private CardDealer myDealer = new CardDealer(new Deck(false));
        /// <summary>
        /// Инициализация
        /// </summary>
        private void frmMainForm_Load(object sender, EventArgs e)
        {
            // Установите изображение колоды на изображение карты
            pbDeck.Image = new PlayingCard().GetCardImage();
            // Подключите обработчик событий out of card
            myDealer.OutOfCards += myDealer_OutOfCards;
            // Показать количество карт в колоде
            lblCardCount.Text = myDealer.CardsRemaining.ToString();
            txtMessages.AppendText("Welcome to Yaniv Card Game!");
            FinishTurn.Enabled = false;
            Throw_button.Enabled = false;
            Show_button.Enabled = false;
            btnReset.Enabled = false;
            lblPlayerBottom.Text = Game.PlayerName;
        }
        /// <summary>
        /// Перезапускаем игру,сбрасываем колоду
        /// </summary>
        private void btnReset_Click(object sender, EventArgs e)
        {
            // Если колода пуста  (no image)
            if (pbDeck.Image == null || isWinner == true)
            {
                // Раздаем карты
                ResetDealer();
            }
            else
            {
                btnReset.Enabled = false;
                MessageBox.Show("В Колоде достаточно карт.", "Game Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Начало игры
        /// Раздача карт игрокам
        /// </summary>
        private void StartButton_Click(object sender, EventArgs e)
        {
            show_s = false;
            // Выдаем 5 карт AI
            for (int i = 0; i <= 4; i++)
            {
                // Создать новую карту
                PlayingCard card = new PlayingCard();
                // Выдача карты 
                if (myDealer.DrawCard(ref card, true))
                {
                    // Создание нового элемента управления CardBox на основе вытянутой карты
                    CardBox aCardBox = new CardBox(card);
                    // Добавить новый элемент управления на соответствующую панель
                    pnlPlayerTop.Controls.Add(aCardBox);
                    // Выравниваем карты
                    RealignCards(pnlPlayerTop);
                    AI_score += card.CardValue;
                    // Рубашкой вверх
                    aCardBox.FaceUp = false;
                    // Добавляем карты AI в коллекцию
                    ai_cards.Add(aCardBox);
                }
            }
            // Выдаем 5 карт игроку
            for (int k = 0; k <= 4; k++)
            {
                // Создать карту
                PlayingCard card = new PlayingCard();
                // Выдача карты 
                if (myDealer.DrawCard(ref card, true))
                {
                    // Создание нового элемента управления CardBox на основе вытянутой карты
                    CardBox aCardBox = new CardBox(card);
                    // Подключите обработчики событий к новому элементу управления
                    aCardBox.Click += CardBox_Click; // 
                    // CardBox_MouseEnter для "POP" визуального эффекта 
                    aCardBox.MouseEnter += CardBox_MouseEnter;
                    // CardBox_MouseLeave для обычного визуального эффекта 
                    aCardBox.MouseLeave += CardBox_MouseLeave;
                    // Добавить новый элемент управления на соответствующую панель
                    pnlPlayerBottom.Controls.Add(aCardBox);
                    // Выравниваем карты
                    RealignCards(pnlPlayerBottom);
                    // Счет игрока + значение карты
                    Player_score += card.CardValue;
                    players_cards.Add(aCardBox);
                }
            }
            // Выводи счет игрока после раздачи
            txtMessages.AppendText(Environment.NewLine);
            txtMessages.AppendText("Player Score: " + Player_score.ToString());
            // Количество карт оставшихся в колоде 
            lblCardCount.Text = myDealer.CardsRemaining.ToString();
            StartButton.Enabled = false;
            Throw_button.Enabled = true;
        }
        /// <summary>
        /// Удаляет изображение карты , когда в колоде нет карт.
        /// </summary>
        private void myDealer_OutOfCards(object sender, EventArgs e)
        {
            pbDeck.Image = null;
        }
        /// <summary>
        ///  Отображает карту при наведении
        /// </summary>
        void CardBox_MouseEnter(object sender, EventArgs e)
        {
            CardBox aCardBox = sender as CardBox;
            if (aCardBox != null)
            {
                // Визуальный эффект
                aCardBox.Size = new Size(regularSize.Width + POP, regularSize.Height + POP);
                // Переместить карту вверх
                aCardBox.Top = 0;
            }
        }
        /// <summary>
        /// Убираем мышь с карты (effect)
        /// </summary>
        void CardBox_MouseLeave(object sender, EventArgs e)
        {
            CardBox aCardBox = sender as CardBox;
            if (aCardBox != null)
            {
                // Стандартный размер карты
                aCardBox.Size = regularSize;
                aCardBox.Top = POP;
            }
        }
        // Кнопка Throw
        private void Throw_button_Click(object sender, EventArgs e)
        {
            if (!take_from_pile && players_cards.Count != 0)
            {
                show_s = true;
                // Если карты есть на поле
                if (collect.Count > 0)
                {
                    var number = from i in collect group i by i.Rank;
                    foreach (IGrouping<CardRank, CardBox> s in number)
                    {
                        if (s.Count() > 1)
                        {
                            // Комбинация по значению
                            combo_Value = true;

                        }
                        else
                        {
                            // Комбинация по значению
                            combo_Value = false; break;
                        }
                    }
                    // Масти
                    var Sort = from o in collect orderby o.Rank descending select o;
                    var suit2 = from p in Sort group p by p.Suit;
                    foreach (IGrouping<CardSuit, CardBox> k in suit2)
                    {
                        if (k.Count() > 1)
                        {
                            var j = k.Min(s => s.Rank);
                            var po = k.Max(s => s.Rank);
                            if (po - j == k.Count() - 1)
                            {
                                // Комбинация по масти
                                combo_suit = true;
                            }
                            else { combo_suit = false; break; }
                        }
                        else
                        {
                            // Комбинация по масти
                            combo_suit = false; break;
                        }
                    }
                }
                // Комбинации карт
                if ((combo_suit || combo_Value) && collect.Count > 0)
                {
                    txtMessages.AppendText(Environment.NewLine);
                    txtMessages.Text = "Данная комбинация существует. >> Finish Turn для завершения хода";
                    show_s = false;
                    FinishTurn.Enabled = true;
                }
                // Если комбинаций нет, скинуть 1 любую карту
                else if (collect.Count == 1)
                {
                    txtMessages.AppendText(Environment.NewLine);
                    txtMessages.Text = "Данная комбинация существует. >> Finish Turn для завершения хода";
                    show_s = false;
                    FinishTurn.Enabled = true;
                }

            }

        }
        /// <summary>
        /// Нажатие на карту и перемещение на поле и обратно
        /// </summary>
        void CardBox_Click(object sender, EventArgs e)
        {
            CardBox aCardBox = sender as CardBox;
            if (aCardBox != null)
            {
                if (show_s == true)
                {
                    // Если карта на панели игрока
                    if (aCardBox.Parent == pnlRiver)
                    {
                        Player_score = Player_score + aCardBox.Card.CardValue;
                        txtMessages.AppendText(Environment.NewLine);
                        txtMessages.AppendText("Your Score: " + Player_score.ToString());
                        // Удаление карты с панели игрока
                        pnlRiver.Controls.Remove(aCardBox);
                        // Нажатие на игровом поле
                        pnlPlayerBottom.Controls.Add(aCardBox);
                        int peremena;
                        peremena = collect.IndexOf(aCardBox);
                        if (peremena != -1)
                        {
                            collect.RemoveAt(peremena);
                        }
                        players_cards.Add(aCardBox);
                        discard_pile.RemoveAt(discard_pile.IndexOf(aCardBox));
                    }
                    else
                    {
                        collect.Add(aCardBox);
                        txtMessages.AppendText(Environment.NewLine);
                        txtMessages.Text = "River card value:" + aCardBox.Card.CardValue.ToString();
                        Player_score = Player_score - aCardBox.Card.CardValue;
                        txtMessages.AppendText(Environment.NewLine);
                        txtMessages.AppendText("Your Score: " + Player_score.ToString());
                        // Удалить карту с игрового поля
                        pnlPlayerTop.Controls.Remove(aCardBox);
                        // Нажатие на панели игрока
                        pnlRiver.Controls.Add(aCardBox);
                        players_cards.RemoveAt(players_cards.IndexOf(aCardBox));
                        //добавление в колоду
                        discard_pile.Add(aCardBox);
                    }
                    // Выравниваем карты
                    RealignCards(pnlRiver);
                    RealignCards(pnlPlayerBottom);
                }
            }

        }
        /// <summary>
        /// Выровнять карты на панели
        /// </summary>
        /// <param name="panelHand"></param>
        private void RealignCards(Panel panelHand)
        {
            // Определяем количество карт или элементов управления на панели.
            int myCount = panelHand.Controls.Count;

            // Если карты есть
            if (myCount > 0)
            {
                int cardWidth = panelHand.Controls[0].Width;
                int startPoint = (panelHand.Width - cardWidth) / 2;
                // Смещение
                int offset = 0;
                // Если на панели несколько карт
                if (myCount > 1)
                {
                    offset = (panelHand.Width - cardWidth - 2 * POP) / (myCount - 1);
                    if (offset > cardWidth)
                    {
                        offset = cardWidth;
                    }
                    // Определяем ширину всех карт
                    int allCardsWidth = (myCount - 1) * offset + cardWidth;
                    startPoint = (panelHand.Width - allCardsWidth) / 2;
                }
                // Выравниваем первую карту
                panelHand.Controls[myCount - 1].Top = POP;
                System.Diagnostics.Debug.Write(panelHand.Controls[myCount - 1].Top.ToString() + "\n");
                panelHand.Controls[myCount - 1].Left = startPoint;
                // для каждого из оставшихся элементов управления в обратном порядке.
                for (int index = myCount - 2; index >= 0; index--)
                {
                    // Выровнять текущую карту
                    panelHand.Controls[index].Top = POP;
                    panelHand.Controls[index].Left = panelHand.Controls[index + 1].Left + offset;
                }
            }
        }
        /// <summary>
        /// Пересобрать колоду
        /// </summary>
        void ResetDealer()
        {
            if (p_main_score >= Game.lose_points || ai_main_score >= Game.lose_points)
            {
                MessageBox.Show("Score: \n" + Game.PlayerName + " Score: " + p_main_score + "\nAI Socre: " + ai_main_score, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            else
            {
                // Очистить панели
                pnlRiver.Controls.Clear();
                pnlPlayerTop.Controls.Clear();
                pnlPlayerBottom.Controls.Clear();
                myDealer.LoadCardDealer();
                Player_score = 0;
                AI_score = 0;
                // Устанавливаем изображение на рубашку карты
                pbDeck.Image = (new PlayingCard()).GetCardImage();
                // Вывести сколько карт осталось в колоде
                lblCardCount.Text = myDealer.CardsRemaining.ToString();
                txtMessages.Text = "New Round Has Begun";
                txtMessages.AppendText("Board reset!");
                txtMessages.Clear();
                StartButton.Enabled = true;
                btnReset.Enabled = false;
                discard_pile_count.Visible = false;
                pile_discard.Visible = false;
                pbTrumpCard.Image = null;
                FinishTurn.Enabled = false;
                take_from_pile = false;
                discard_pile.Clear();
                collect.Clear();
            }
        }
        // Закрытие окна
        private void frmMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        // Кнопка exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Закончить ход
        private void FinishTurn_Click(object sender, EventArgs e)
        {
            collect.Clear();
            // Если ход AI
            if (ai_turn)
            {
                txtMessages.AppendText(Environment.NewLine);
                txtMessages.Text = "AI Turn";
                Show_button.Enabled = false;
                Throw_button.Enabled = false;
                // Если кол-во очков на руках достаточно
                if (AI_score <= Game.win_points)
                {
                    // Победа в раунде?
                    if (Player_score >= AI_score)
                    {
                        // Начало нового раунда
                        p_main_score += Player_score;
                        ai_main_score += AI_score;
                        label1_score.Text = "Main Score: " + p_main_score.ToString();
                        txtMessages.AppendText(Environment.NewLine);
                        txtMessages.AppendText("AI Main Score: " + ai_main_score.ToString());
                        txtMessages.AppendText(Environment.NewLine);
                        txtMessages.AppendText("Round Winner is AI Player");
                        txtMessages.AppendText(Environment.NewLine);
                        txtMessages.AppendText("Click Reset To Continue.......");
                        Show_button.Enabled = false;
                        Throw_button.Enabled = false;
                        FinishTurn.Enabled = false;
                        isWinner = true;
                    }
                    else
                    {
                        // Начало нового раунда
                        p_main_score += Player_score;
                        ai_main_score += AI_score;
                        label1_score.Text = "Main Score: " + p_main_score.ToString();
                        txtMessages.AppendText(Environment.NewLine);
                        txtMessages.AppendText("AI Main Score: " + ai_main_score.ToString());
                        txtMessages.AppendText(Environment.NewLine);
                        txtMessages.AppendText("Round Winner is " + Game.PlayerName);
                        txtMessages.AppendText(Environment.NewLine);
                        txtMessages.AppendText("Click Reset To Continue.......");
                        Show_button.Enabled = false;
                        Throw_button.Enabled = false;
                        FinishTurn.Enabled = false;
                        isWinner = true;
                    }
                }
                else
                {

                    pnlRiver.Controls.Clear();
                    pbTrumpCard.Image = (new PlayingCard()).GetCardImage();
                    discard_pile_count.Text = discard_pile.Count.ToString();

                    // логика AI
                    if (ai_cards.Count > 0)
                    {
                        // Значение
                        var number2 = from i in ai_cards group i by i.Rank;
                        foreach (IGrouping<CardRank, CardBox> s in number2)
                        {
                            if (s.Count() > 1)
                            {
                                ai_combo.AddRange(s);
                                combo_Value = true; break;

                            }
                            else
                            {
                                combo_Value = false; 
                            }
                        }
                        if (!combo_Value)
                        {
                            // Масти
                            var Sort = from o in ai_cards orderby o.Rank descending select o;
                            var suit2 = from p in Sort group p by p.Suit;
                            foreach (IGrouping<CardSuit, CardBox> k in suit2)
                            {
                                if (k.Count() > 1)
                                {
                                    var j = k.Min(s => s.Rank);
                                    var po = k.Max(s => s.Rank);
                                    if (po - j == k.Count() - 1)
                                    {
                                        ai_combo.AddRange(k);
                                        combo_suit = true; break;
                                    }
                                    else { combo_suit = false; }
                                }
                                else
                                {
                                    combo_suit = false;
                                }
                            }
                        }
                        // Комбинации карт
                        if ((combo_suit || combo_Value) && ai_cards.Count > 0)
                        {
                            foreach (var item in ai_combo)
                            {
                                ai_cards.Remove(item);
                            }
                            for (int i = 0; i < ai_combo.Count; i++)
                            {
                                collect.Add(ai_combo[i]);
                                //изменение счета для ИИ
                                AI_score = AI_score - ai_combo[i].Card.CardValue;
                                ai_combo[i].FaceUp = true;
                                pnlPlayerTop.Controls.Remove(ai_combo[i]);
                                pnlRiver.Controls.Add(ai_combo[i]);
                                //добавление в колоду
                                discard_pile.Add(ai_combo[i]);
                                // кол-во карт которые нужно взять
                            }
                            ai_combo.Clear();
                            ai_turn = false;
                        }
                        // Если комбинаций нет, скинуть 1 любую карту
                        else
                        {
                            var ai_crd = from o in ai_cards orderby o.Rank descending select o;
                            foreach (var item in ai_crd)
                            {
                                ai_cards.Remove(item);
                                collect.Add(item);
                                //изменение счета для ИИ
                                AI_score = AI_score - item.Card.CardValue;

                                // Remove the card from the play panel
                                pnlPlayerTop.Controls.Remove(item);
                                // Add the control to the home panel
                                pnlRiver.Controls.Add(item);
                                //добавление в колоду
                                discard_pile.Add(item);
                                // брать карту
                                item.FaceUp = true;
                                break;
                            }

                            ai_turn = false;
                        }
                        //
                    }
                    // логика AI 
                    collect.Clear();
                    // Выравниваем карты
                    RealignCards(pnlRiver);
                    RealignCards(pnlPlayerTop);
                    ai_turn = false;
                }

            }
            else
            {
                if (discard_pile.Count > 0 || !take_from_pile)
                {
                    pnlRiver.Controls.Clear();
                    pbTrumpCard.Image = (new PlayingCard()).GetCardImage();
                    discard_pile_count.Text = discard_pile.Count.ToString();
                    take_from_pile = true;
                    discard_pile_count.Visible = true;
                    pile_discard.Visible = true;
                    collect.Clear();
                    Throw_button.Enabled = false;
                    FinishTurn.Enabled = false;
                    Show_button.Enabled = false;
                    Throw_button.Enabled = false;
                    ai_turn = true;
                }
                else
                    MessageBox.Show("Сейчас не ваша очередь брать карту!", "Game Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        // Взять карту из отбоя
        private void pbTrumpCard_Click(object sender, EventArgs e)
        {
            if (take_from_pile)
            {

                CardBox aCardBox = discard_pile[discard_pile.Count - 1] as CardBox;
                players_cards.Add(aCardBox);
                discard_pile.RemoveAt(discard_pile.Count - 1);
                if (discard_pile.Count == 0)
                    pbTrumpCard.Image = null;

                Player_score = Player_score + aCardBox.Card.CardValue;
                aCardBox.Click += CardBox_Click;
                // CardBox_MouseEnter для "POP" визуального эффекта 
                aCardBox.MouseEnter += CardBox_MouseEnter;
                // CardBox_MouseLeave для обычного визуального эффекта 
                aCardBox.MouseLeave += CardBox_MouseLeave;
                // Добавить новый элемент управления на соответствующую панель
                pnlPlayerBottom.Controls.Add(aCardBox);
                discard_pile_count.Text = discard_pile.Count.ToString();
                // Выравниваем карты
                RealignCards(pnlRiver);
                RealignCards(pnlPlayerBottom);
                take_from_pile = false;
                discard_pile_count.Text = discard_pile.Count.ToString();
                Throw_button.Enabled = true;
                Show_button.Enabled = true;
                AI_take_aCard();
                lblCardCount.Text = myDealer.CardsRemaining.ToString();
                txtMessages.AppendText(Environment.NewLine);
                txtMessages.AppendText("Player Score: " + Player_score);

            }
        }
        // Взять карту из колоды
        private void pbDeck_Click(object sender, EventArgs e)
        {
            if (take_from_pile)
            {
                // Создать карту
                PlayingCard card = new PlayingCard();
                // Выдача карты 
                if (myDealer.DrawCard(ref card, true))
                {
                    // Создание нового элемента управления CardBox на основе вытянутой карты
                    CardBox aCardBox = new CardBox(card);

                    // Подключите обработчики событий к новому элементу управления
                    aCardBox.Click += CardBox_Click; // 

                    // CardBox_MouseEnter для "POP" визуального эффекта 
                    aCardBox.MouseEnter += CardBox_MouseEnter;

                    // CardBox_MouseLeave для обычного визуального эффекта 
                    aCardBox.MouseLeave += CardBox_MouseLeave;

                    // Добавить новый элемент управления на соответствующую панель
                    pnlPlayerBottom.Controls.Add(aCardBox);

                    // Выравниваем карты
                    RealignCards(pnlPlayerBottom);
                    // Счет игрока + значение карты
                    Player_score += card.CardValue;
                    players_cards.Add(aCardBox);
                }
                take_from_pile = false;
                Throw_button.Enabled = true;
                btnReset.Enabled = true;
                Show_button.Enabled = true;
                AI_take_aCard();
                lblCardCount.Text = myDealer.CardsRemaining.ToString();
                txtMessages.AppendText(Environment.NewLine);
                txtMessages.AppendText("Player Score: " + Player_score);
            }
        }
        // Подсказка для игрока,использовать 1 раз.
        private void button_hint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hint:\n" +
                 "\n" +
                 "Number of Player: 2\n" +
                 "\n" +
                 "Taken from https://www.catsatcards.com/Games/Yaniv.html \n" +
                 "\nВ свою очередь, игрок может сыграть только одну легальную игру, но эта игра может состоять из нескольких карт в зависимости от ситуации. Ниже показаны возможные легальные типы игры, которые игрок может делать в свой ход: \n" +
                 "\nОдиночная карта\nИгрок может бросить любую карту из своей руки на стол.Обычно он делал это, когда у него нет других вариантов.\n" +
                 "\nНабор того же ранга\nИгрок может бросить две или более карт во время своего хода при условии, что все карты,имеют одинаковый ранг(то есть три девятки или три короля).\n" +
                 "\nПоследовательность\nИгрок может бросить последовательность, состоящую из трех или более карт.Все карты должны быть одной масти и иметь прямую числовую последовательность(т.Е.Три, четыре и пять пиков или десять, валет, дама и король в одной масти треф).\n" +
                 "\n", "Hint", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Убрать подсказку
            button_hint.Enabled = false;
        }
        // Нажатие на кнопку Show
        private void Show_button_Click(object sender, EventArgs e)
        {
            // Игрок может показать карты после того,как завершил свой ход
            if (take_from_pile == false)
            {
                if (Player_score <= Game.win_points)
                {
                    if (Player_score >= AI_score)
                    {
                        // Начало нового раунда
                        p_main_score += Player_score;
                        ai_main_score += AI_score;
                        label1_score.Text = "Main Score: " + p_main_score.ToString();
                        txtMessages.AppendText(Environment.NewLine);
                        txtMessages.AppendText("AI Main Score: " + ai_main_score.ToString());
                        txtMessages.AppendText(Environment.NewLine);
                        txtMessages.AppendText("Round Winner is AI Player");
                        txtMessages.AppendText(Environment.NewLine);
                        txtMessages.AppendText("Click Reset To Continue.......");
                        Show_button.Enabled = false;
                        Throw_button.Enabled = false;
                        isWinner = true;
                    }
                    else
                    {
                        // Начало нового раунда
                        p_main_score += Player_score;
                        ai_main_score += AI_score;
                        label1_score.Text = "Main Score: " + p_main_score.ToString();
                        txtMessages.AppendText(Environment.NewLine);
                        txtMessages.AppendText("AI Main Score: " + ai_main_score.ToString());
                        txtMessages.AppendText(Environment.NewLine);
                        txtMessages.AppendText("Round Winner is " + Game.PlayerName);
                        txtMessages.AppendText(Environment.NewLine);
                        txtMessages.AppendText("Click Reset To Continue.......");
                        Show_button.Enabled = false;
                        Throw_button.Enabled = false;
                        isWinner = true;
                    }
                }
                else
                {
                    MessageBox.Show("Колличество очков на руках превышает установленное условием", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else { MessageBox.Show("Вы не взяли карту из колоды!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        // Ai берет карту из колоды
        private void AI_take_aCard()
        {
            PlayingCard card = new PlayingCard();
            // Выдача карты 
            if (myDealer.DrawCard(ref card, true))
            {
                // Создание нового элемента управления CardBox на основе вытянутой карты
                CardBox aCardBox = new CardBox(card);
                // Добавить новый элемент управления на соответствующую панель
                pnlPlayerTop.Controls.Add(aCardBox);
                aCardBox.FaceUp = false;
                // Выравниваем карты
                RealignCards(pnlPlayerTop);
                // Счет AI + значение карты
                ai_cards.Add(aCardBox);
                AI_score = AI_score + card.CardValue;
            }
        }
    }
}