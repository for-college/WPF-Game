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
    /// Логика взаимодействия для ChooseGame.xaml
    /// </summary>
    public partial class ChooseGame : Window
    {
        public ChooseGame()
        {
            InitializeComponent();
        }

        private void OpenWhereMore(object sender, RoutedEventArgs e)
        {
            Game game = new Game();
            game.ShowDialog();
        }

        private void Calc(object sender, RoutedEventArgs e)
        {
            Calc calc = new Calc();
            calc.Show();
        }

        private void OpenIsItRight(object sender, RoutedEventArgs e)
        {

        }
    }
}
