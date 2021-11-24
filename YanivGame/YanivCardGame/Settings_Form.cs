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
    public partial class Settings_Form : Form
    {
        public Settings_Form()
        {
            InitializeComponent();
        }
        // Подтвердить настройки
        private void button1_start_Click(object sender, EventArgs e)
        {
            try
            {
                // Если поле имени не заполнено
                if (nameTextBox.Text == "")
                {
                    MessageBox.Show("Please enter name","Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                GameSettings gameSettings = new GameSettings(nameTextBox.Text, "AI_1", numericUpDown_l_points.Value, numericUpDown_w_point.Value);
                this.Hide();
                frmMainForm mainForm = new frmMainForm(gameSettings);
                mainForm.Show();
                this.Visible = false;
                nameTextBox.Clear();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Закрытие
        private void Settings_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
