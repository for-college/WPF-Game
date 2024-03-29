﻿using System;
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
        int roundsAmount = Data.rounds;
        int currentRound = Data.currentRound;
        int temp;
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
        private void Gaming(int a, int b)
        {

            if (a > b) ++score;
            Random();
            Rounds();
        }
        public void Random()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            firstInt = random.Next(1, 5000);
            secondInt = random.Next(1, 5000);
            if (firstInt == secondInt) Random();
            firstNumber.Text = firstInt.ToString();
            secondNumber.Text = secondInt.ToString();
        }
        public void Rounds()
        {
            currentRound++;
            if (currentRound > roundsAmount) TheEnd();
            rounds.Text = "[" + currentRound + "/" + Data.rounds + "]";
        }
        public void TheEnd()
        {
            temp++;
            MessageBox.Show($"Очков набрано: {score}", "Конец раунда");
            currentPlayer.Text = $"Настала очередь игрока {name2}!";
            rounds.Text = "[1/" + Data.rounds + "]";
            if (temp > 1)
            {
                Data.player2_result = score;
                Data.OpenWinner();
                Close();
            }
            else Data.player1_result = score;
            currentRound = 1;
            score = 0;
            Random();
        }
    }
}
