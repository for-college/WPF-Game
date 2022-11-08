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
    /// Логика взаимодействия для Rules.xaml
    /// </summary>
    public partial class Rules : Window
    {
        public Rules()
        {
            InitializeComponent();
        }

        private void RulesButton(object sender, RoutedEventArgs e)
        {
            string[] rules = {"Допускается 6 ошибок", "Используются слова только на русском языке", "Сквернословие не использутся", "предполедний","последний элемент"};
            for(int i = 0; i < rules.Length; i++)
            {
                rulesBlock.Text = rules[i];
                
            }
        }
    }
}
