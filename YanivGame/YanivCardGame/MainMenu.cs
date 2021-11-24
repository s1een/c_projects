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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        // Информация
        private void button_Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Работу выполнил:\nСтудент группы 525Б\nМорозов Д.С.\nАктуальная версия программы: 0.2", "Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        // Правила игры отображаются по нажатию на кнопку
        private void button_rules(object sender, EventArgs e)
        {
            // Правила игры
            MessageBox.Show("Rules:\n" +
                "\n" +
                "Number of Player: 2\n" +
                "\n" +
                "Taken from http://www.durbetsel.ru/2_yaniv.htm \n\n" +
                "\nПоложить в сброс одну или несколько карт, при этом если кладется одна карта, то она кладется поверх сброса в открытом виде, если кладется несколько карт, то верхняя карта этих нескольких карт, должна быть положена в открытом виде.\n" +
                "\nСбрасывать разрешается любую из карт, набор из двух или более карт одного достоинства, последовательность из трех или более последовательных карт одной масти (4-5-6).\n" +
                "\nПосле того, как игрок сбросит карту, он должен взять только одну карту либо из оставшейся колоды, либо с верха сброса, то есть карту, которую сбросил последний игрок, если игрок сбросил несколько карт, то игрок берет или верхнюю карту или нижнюю из сброшенных предыдущим игроком.\n" +
                "\nНажать Show, заканчивая игру, если общая сумма карт игрока меньше установленной в настройках и игрок считает, что другие игроки имеют более высокие очки за свои карты.\n\nСтоит заметить, что игрок не обязан говорить , когда у него 6 или менее очков, игрок может продолжать сбрасывать карты и ждать следующего хода, чтобы нажать Show.\n" +
                "\n","Game Rules",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        /// <summary>
        /// Настройка 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Settings_Click(object sender, EventArgs e)
        {
            Settings_Form s = new Settings_Form();
            s.Show();
            this.Visible = false;
        }
        /// <summary>
        /// Настройка 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings_Form s = new Settings_Form();
            s.Show();
            this.Visible = false;
        }
        // Выход
        private void mnuGameExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // При нажатии используются стандартные настройки
        private void playButton_Click(object sender, EventArgs e)
        {
            try
            {
                GameSettings gameSettings = new GameSettings("User1","AI_1",100,10);
                this.Hide();
                frmMainForm mainForm = new frmMainForm(gameSettings);
                mainForm.Show();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
