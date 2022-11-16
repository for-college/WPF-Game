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
        int firstInt; // первое число (левое)
        int secondInt; // второе число (правое)
        int score; // кол-во очков игрока
        int roundsAmount = Data.rounds; // кол-во раундов
        int currentRound = 1; // текущий раунд
        int temp; // 
        string name1 = Data.playerOne;
        string name2 = Data.playerTwo;

        public Game()
        {
            InitializeComponent();
            Random();
            rounds.Text = "[1/" + Data.rounds +  "]";
            currentPlayer.Text += $" {name1}!";

        }
        private void ButtonLeft(object sender, RoutedEventArgs e) => Gaming(firstInt, secondInt);

        private void ButtonRight(object sender, RoutedEventArgs e) => Gaming(secondInt, firstInt);
        private void Random()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            firstInt = random.Next(1, 5000);
            secondInt = random.Next(1, 5000);

            firstNumber.Text = firstInt.ToString();
            secondNumber.Text = secondInt.ToString();
        }
        private void Gaming(int a, int b)
        {
            if (currentRound < roundsAmount)
            {
                if (a > b) score++;
                Random();
                Rounds();
            }
            else TheEnd();
        }
        private void Rounds()
        {
            currentRound++;
            rounds.Text = "[" + currentRound + "/" + Data.rounds + "]";
        }
        private void TheEnd()
        {
            temp++;
            int scoreShow = score == 0 || score < 5 ? score : score + 1;
            MessageBox.Show($"Очков набрано: {scoreShow}", "Конец раунда");
            currentPlayer.Text = $"Настала очередь игрока {name2}!";
            rounds.Text = "[1/" + Data.rounds + "]";
            if (temp > 1)
            {
                Data.player2_result = score; // передача кол-ва очков в другое окно
                OpenWinner();
               
            }
            else Data.player1_result = score; // передача кол-ва очков в другое окно
            currentRound = 1;
            score = 0;
            Random();
        }
        private void OpenWinner()
        {
            Winner winner = new Winner();
            winner.ShowDialog();
            Close();
        }
    }
}
