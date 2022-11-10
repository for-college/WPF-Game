using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyGame
{
    /// <summary>
    /// Логика взаимодействия для Game.xaml
    /// </summary>
    public partial class Game : Window
    {
        int firstInt;
        int secondInt;
        int score;
        int round;
        int player1_result;
        int player2_result;
        int temp;
        string name1 = Data.playerOne;
        string name2 = Data.playerTwo;

        Random random = new Random(DateTime.Now.Millisecond);
        public Game()
        {
            InitializeComponent();
            Random();
        }
        private void ButtonLeft(object sender, RoutedEventArgs e)
        {
            Gaming(false);
        }

        private void ButtonRight(object sender, RoutedEventArgs e)
        {
            Gaming(true);
        }
        private void TheEnd()
        {
            temp++;
            MessageBox.Show($"Очков набрано: {score + 1}", "Конец раунда");
            if (temp > 1)
            {
                player2_result = score;
                if (player1_result > player2_result)
                {
                    MessageBox.Show($"Выиграл {name1}!", "Конец игры");
                    Close();
                }
                else if(player1_result == player2_result)
                {
                    MessageBox.Show($"Ничья!", "Конец игры");
                    Close();
                }
                else
                {
                    MessageBox.Show($"Выиграл {name2}!", "Конец игры");
                    Close();
                }
               
            }
            else { player1_result = score; }
            round = 0;
            score = 0;
            Random();
        }
        private void Random()
        {
            firstInt = random.Next(1, 5000);
            secondInt = random.Next(1, 5000);

            firstNumber.Text = firstInt.ToString();
            secondNumber.Text = secondInt.ToString();
        }
        private void Gaming(bool more) 
        {
            if(round < 4)
            {
                if (more == true)
                {
                    if (Convert.ToInt32(firstNumber.Text) < Convert.ToInt32(secondNumber.Text)) score++;
                }
                else
                {
                    if (Convert.ToInt32(firstNumber.Text) > Convert.ToInt32(secondNumber.Text)) score++;
                }
                Random();
                round++;
            }
            else { TheEnd(); }
        }
    }
}
