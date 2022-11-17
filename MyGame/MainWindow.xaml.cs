using System;
using System.Collections.Generic;
using System.Linq;
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
        public MainWindow()
        {
            InitializeComponent();
        }

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
            if (player1.Text == "" || player2.Text == "") MessageBox.Show("Заполните обязательные!", "Ошибочка", MessageBoxButton.OK, MessageBoxImage.Warning);
            else
            {
                if (rounds.Text == "") Data.rounds = 5;
                else if (rounds.Text != "") Data.rounds = Convert.ToInt32(rounds.Text);
                else MessageBox.Show("Неверное количество раундов!", "Ошибочка", MessageBoxButton.OK, MessageBoxImage.Warning);
                Data.playerOne = player1.Text;
                Data.playerTwo = player2.Text;
                if (checkName1.IsChecked == false) player1.Text = "";
                if (checkName2.IsChecked == false) player2.Text = "";
                ChooseGame cg = new ChooseGame();
                cg.ShowDialog();
            }
        }
    }
}
