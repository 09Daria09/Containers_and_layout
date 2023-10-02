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

namespace Determinant
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

        private void Result_Click(object sender, RoutedEventArgs e)
        {
            List<TextBox> textBoxes = new List<TextBox>
    {
        TextBox00, TextBox01, TextBox02,
        TextBox10, TextBox11, TextBox12,
        TextBox20, TextBox21, TextBox22
    };

            foreach (var textBox in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text) || !double.TryParse(textBox.Text, out _))
                {
                    MessageBox.Show("Введите корректные числа во все поля!");
                    return;
                }
            }
            double a11 = double.Parse(TextBox00.Text);
            double a12 = double.Parse(TextBox01.Text);
            double a13 = double.Parse(TextBox02.Text);
            double a21 = double.Parse(TextBox10.Text);
            double a22 = double.Parse(TextBox11.Text);
            double a23 = double.Parse(TextBox12.Text);
            double a31 = double.Parse(TextBox20.Text);
            double a32 = double.Parse(TextBox21.Text);
            double a33 = double.Parse(TextBox22.Text);

            double determinant = a11 * a22 * a33 - a11 * a23 * a32 - a12 * a21 * a33 + a12 * a23 * a31 + a13 * a21 * a32 - a13 * a22 * a31;

            TextBoxResult.Text = determinant.ToString("F2");
        }
    }
}
