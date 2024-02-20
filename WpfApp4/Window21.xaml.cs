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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для Window21.xaml
    /// </summary>
    public partial class Window21 : Window
    {
        public static Window22 window22;
        public Window21()
        {
            InitializeComponent();
        }

        private void BtnTasck21_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tba21.Text) || string.IsNullOrEmpty(Tbx21.Text) || string.IsNullOrEmpty(Tbz21.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №21",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tba21.Text = string.Empty;
                Tbx21.Text = string.Empty;
                Tbz21.Text = string.Empty;
            }
            else
            {
                double a21 = Convert.ToDouble(Tba21.Text), x21 = Convert.ToDouble(Tbx21.Text), z21 = Convert.ToDouble(Tbz21.Text);

                MessageBox.Show($" N21 ={(Math.Pow(Math.Sqrt(z21 + Math.Sqrt(z21 * x21)), 5)) / (Math.Exp(x21) + Math.Pow(a21, 5) * Math.Atan(x21))}",
                                "Задание №21",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tba21.Text = string.Empty;
                Tbx21.Text = string.Empty;
                Tbz21.Text = string.Empty;

            }
        }

        private void Btnw21_Click(object sender, RoutedEventArgs e)
        {
            if (window22 == null)
            {
                window22 = new Window22();
                window22.Show();
            }
            else window22.Activate();
        }
    }
}
