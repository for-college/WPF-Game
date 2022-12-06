using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int roundsInt = Data.rounds;
        public MainWindow() => InitializeComponent();
        private void ShowRules(object sender, RoutedEventArgs e)
        {
            Rules rules = new Rules();
            rules.ShowDialog();
        }
        private void CloseWindow(object sender, RoutedEventArgs e) => Close();
        private void OpenAuthorWindow(object sender, RoutedEventArgs e)
        {
            Author author = new Author();
            author.ShowDialog();
        }
        private void OpenGameList(object sender, RoutedEventArgs e)
        {
            if (rounds.Text == "") roundsInt = 5;
            try
            {
                if(rounds.Text != "") roundsInt = Convert.ToInt32(rounds.Text);
                if(player1.Text == "" || player2.Text == "") throw new Exception("Не все обязательные поля заполнены");
                if(roundsInt <= 0) throw new Exception("Количество раундов < 0");
                else GameList();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message, "Ошибочка", MessageBoxButton.OK, MessageBoxImage.Warning); }
        }
        private void GameList()
        {
            Data.playerOne = player1.Text;
            Data.playerTwo = player2.Text;
            Data.rounds = roundsInt;
            if (checkName1.IsChecked == false) player1.Text = "";
            if (checkName2.IsChecked == false) player2.Text = "";
            ChooseGame cg = new ChooseGame();
            cg.ShowDialog();
        }
    }
}
