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
      
        string[] rules = {
                "Сначала играет игрок №1, затем очередь игрока №2.",
                "Имена игроков должны быть заполнены.",
                "В качестве количества раундов вводить строго целое положительное число.", "Если количество раундов не задано, то по умолчанию оно будет равно 5",
                "Если разделить нацело не представляется возможным, то в ответ стоит вводить только целую часть.",
                "После окончания игры вы можете начать снова, предыдущий результать не учитывается.",
                "Удачной игры!"};
        private void NextRule(object sender, RoutedEventArgs e)
        {
            if (counter == 1) ruleButtonBefore.IsEnabled = true;
            if (counter + 1 == rules.Length) ruleButtonNext.IsEnabled = false;
            else ruleButtonNext.IsEnabled = true;
            rulesBlock.Text = $" [{counter + 1}/"+ rules.Length + "] " + rules[counter];
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
            rulesBlock.Text = $" [{counter}/"+ rules.Length + "] " + rules[counter - 1];
        }

        public void CloseWindow(object sender, RoutedEventArgs e) => Close();
    }
}
