using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUIDemo
{
    public class GameSettings
    {
        // имя пользователя
        public string PlayerName;
        // ИИ
        public string AI_1;
        // Кол-во очков для окончания игры
        public decimal lose_points;
        // Кол-во очков для окончания раунда
        public decimal win_points;
        // Конструктор настроек
        public GameSettings(string name, string ai_1, decimal l_point, decimal w_point)
        {
            PlayerName = name;
            AI_1 = ai_1;
            lose_points = l_point;
            win_points = w_point;
        }
    }
}