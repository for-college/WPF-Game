using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace MyGame
{
    /// <summary>
    /// Логика взаимодействия для Winner.xaml
    /// </summary>
    public partial class Winner : Window
    {
        int player1_result = Data.player1_result; // кол-во очков игрока 1 
        int player2_result = Data.player2_result; // кол-во очков игрока 2

        string name1 = Data.playerOne;
        string name2 = Data.playerTwo;
        public Winner()
        {
            InitializeComponent();
            if (player1_result > player2_result)
            {
                showWinner.Text += $" {name1}!";
            }
            else if (player1_result == player2_result)
            {
                winnerTitle.Text = "Ничья";
                showWinner.Text = "Победила дружба!";
            }
            else
            {
                showWinner.Text += $" {name2}!";
            }
        }
    }
}
