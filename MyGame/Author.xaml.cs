using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Логика взаимодействия для Author.xaml
    /// </summary>
    public partial class Author : Window
    {
        public Author()
        {
            InitializeComponent();
        }
        public void CloseWindow(object sender, RoutedEventArgs e) => Close();

        private void OpenGitHub(object sender, RoutedEventArgs e) => Process.Start("https://github.com/scffs");

        private void OpenVK(object sender, RoutedEventArgs e) => Process.Start("https://vk.com/scoffs");
        private void OpenWeb(object sender, RoutedEventArgs e) => Process.Start("https://scffs.github.io/dev/");
    }
}
