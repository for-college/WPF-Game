using System;
using System.Collections.Generic;
using System.Data;
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
            ruleButtonBefore.IsEnabled = false;
        }
        int counter;
        string[] rules = {"Используются слова только на русском языке",
                "Сквернословия не использутся",
                "Первую букву слова слова следует вводить в верхнем регистре","Удачной игры!"};
        private void NextRule(object sender, RoutedEventArgs e)
        {
            if (counter == 1)
            {
                ruleButtonBefore.IsEnabled = true;
            }
            if (counter + 1 == rules.Length)
            {
                ruleButtonNext.IsEnabled = false;
            }
            else
            {
                ruleButtonNext.IsEnabled = true;
            }
            rulesBlock.Text = $" [{counter + 1}/ 4] " + rules[counter];
            counter++;
        }
        private void PrevRule(object sender, RoutedEventArgs e)
        {
            counter--;
            if (counter - 1 <= 0)
            {
                ruleButtonBefore.IsEnabled = false;
                ruleButtonNext.IsEnabled = true;
            }
            else
            {
                ruleButtonBefore.IsEnabled = true;
                ruleButtonNext.IsEnabled = true;
            }
            rulesBlock.Text = $" [{counter}/ 4] " + rules[counter - 1];
        }
    }
}
