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

namespace Safe
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && textBox.Text.Length < 4)
            {
                textBox.Text += btn.Content.ToString();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "5224")
            {
                MessageBox.Show("Пароль верный", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Пароль неверный", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            textBox.Clear();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            textBox.Clear();
        }
    }
}
