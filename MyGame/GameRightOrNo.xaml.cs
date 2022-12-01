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

namespace MyGame
{
    /// <summary>
    /// Логика взаимодействия для GameRightOrNo.xaml
    /// </summary>
    public partial class GameRightOrNo : Window
    {
        string[,] answered;
        int score;
        int roundsAmount = Data.rounds;
        int currentRound = Data.currentRound;
        int temp;
        static int currentQuestion;
        string name1 = Data.playerOne;
        string name2 = Data.playerTwo;
        string[,] questions = {  { "Каждый внешний угол из треугольника является столь же большим как два не примыкающим внутренним углом вместе", "1" },
                                     { "В прямоугольном треугольнике сумма квадратов длин катетов равна кубу длины гипотенузы.", "0" },
                                     { "Квадрат длины стороны треугольника равен сумме квадратов длин других сторон минус удвоенное произведение длин этих сторон на косинус угла между ними.", "1" },
                                     { "Сумма углов только равнобедренного треугольника равна 180", "0" },
                                     { "Теорема Виета работает не только для приведенного квадратного уравнения.", "1" },
                                     { "Квадратный корень из 2 больше двух.", "0" },
                                     { "Корень 7-ой степени из -2187 меньше нуля", "0" },
                                     { "2 в 5 степени - 32", "1" },
                                     { "В прямоугольном треугольнике сумма квадратов длин катетов равна квадрату длины гипотенузы.", "1" }};
        public GameRightOrNo()
        {
            InitializeComponent();
            Random();
            rounds.Text = "[1/" + Data.rounds + "]";
            currentPlayer.Text += $" {name1}!";
            questionScreen.Text = $"{questions[currentQuestion, 0]}";
        }
        private void ButtonFalse(object sender, RoutedEventArgs e) => Gaming(0);

        private void ButtonTrue(object sender, RoutedEventArgs e) => Gaming(1);
        private void Gaming(int a)
        {
            for(int i = 0; i < questions.GetLength(0); i++)
            {
                if (a == 0 && questions[currentQuestion, 1] == "0")
                {
                    score++; 
                    break;
                }
                else if (a == 1 && questions[currentQuestion, 1] == "1")
                {
                    score++;
                    break;
                }
            }
            currentQuestion++;
            Random();
            Rounds();
        }
        public void Random()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            currentQuestion = random.Next(0, questions.GetLength(0));
            questionScreen.Text = $"{questions[currentQuestion, 0]}";

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
