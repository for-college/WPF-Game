using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
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
    /// Логика взаимодействия для Calc.xaml
    /// </summary>
    public partial class Calc : Window
    {
        int exampleMass;
        int score;
        int currentRound = Data.currentRound; // текущий раунд
        int number1;
        int number2;
        int roundsAmount = Data.rounds; // кол-во раундов
        int temp;

        string name1 = Data.playerOne;
        string name2 = Data.playerTwo;
        static string symb;
        public Calc()
        {
            InitializeComponent();
            Random();
            rounds.Text = "[1/" + Data.rounds + "]";
            currentPlayer.Text += $" {name1}!";
            example.Text = $"{number1} {symb} {number2}";
        }
        public void Random()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            if (number1 + 1 % 2 == 0) symb = "+";
            else if (number2 % 2 == 0) symb = "-";
            else if (number2 % 3 == 0) symb = "*";
            else symb = "/";

            number1 = random.Next(1, 20);
            number2 = random.Next(1, 10);
        }
        private void Answer(object sender, RoutedEventArgs e)
        {
            try
            {
                if (exampleMass == Convert.ToInt32(exampleAnswer.Text)) score++;
            }
            catch
            {
                MessageBox.Show("Введены неверные данные. Игра продолжается.");
            }
            exampleAnswer.Text = "";
            Random();
            Gaming();
            currentRound++;
            if (currentRound > roundsAmount) TheEnd();
            rounds.Text = "[" + currentRound + "/" + Data.rounds + "]";
        }
        private void Gaming()
        {
            example.Text = $"{number1} {symb} {number2}";
            switch (symb)
            {
                case "+":
                    exampleMass = number1 + number2;
                    break;
                case "-":
                    exampleMass = number1 - number2;
                    break;
                case "*":
                    exampleMass = number1 * number2;
                    break;
                case "/":
                    exampleMass = number1 / number2;
                    break;
            }
        }
        public void TheEnd()
        {
            temp++;
            MessageBox.Show($"Очков набрано: {score}", "Конец раунда");
            currentPlayer.Text = $"Настала очередь игрока {name2}!";
            rounds.Text = "[1/" + Data.rounds + "]";
            if (temp > 1)
            {
                Data.player2_result = score; // передача кол-ва очков в другое окно
                Data.OpenWinner();
                Close();
            }
            else Data.player1_result = score; // передача кол-ва очков в другое окно
            currentRound = 1;
            score = 0;
            Random();
        }
    }
}
