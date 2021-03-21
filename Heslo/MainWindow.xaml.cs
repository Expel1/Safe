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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Heslo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {
            if (Name.Text.Length <= 1)
            {
                MessageBox.Show($"Jméno nemůže menší než 1");
            }
            else if (Name.Text.Contains(',') || Name.Text.Contains(' ')|| Name.Text.Contains('.'))
            {
                MessageBox.Show($"Jméno nemůže obsahobat znaky\',\' \' \' a \'.\'");
            }
            else MessageBox.Show($"Vítej uživateli {Name.Text}.");

            if (Password.Text.Length <= 6)
            {
                MessageBox.Show($"Heslo nemůže menší než 6");
            }
            else if (Password.Text.Contains(',') || Password.Text.Contains(' ') || Password.Text.Contains('.')|| Password.Text.Contains('_')|| Password.Text.Contains('-'))
            {
                MessageBox.Show($"Heslo nemůže obsahobat znaky\',\' \' \' a \'.\'");
            }
            else MessageBox.Show($"Heslo ůspěšně zadáno.");

        }
    }
}
