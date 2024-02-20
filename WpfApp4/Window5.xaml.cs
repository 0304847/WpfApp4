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
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public static Window6 window6;
        public Window5()
        {
            InitializeComponent();
        }

        private void BtnTasck5_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tbc5.Text) || string.IsNullOrEmpty(Tby5 .Text) || string.IsNullOrEmpty(Tbz5.Text) || string.IsNullOrEmpty(Tbx5.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №5",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tby5.Text = string.Empty;
                Tbc5.Text = string.Empty;
                Tbz5.Text = string.Empty;
                Tbx5.Text = string.Empty;
            }
            else
            {
                double x5 = Convert.ToDouble(Tbx5.Text), c5 = Convert.ToDouble(Tbc5.Text), y5 = Convert.ToDouble(Tby5.Text), z5 = Convert.ToDouble(Tbz5.Text);

                MessageBox.Show($"G5 = {(Math.Tan(Math.Pow(x5, 4) - 6) - Math.Pow(Math.Cos(z5 + x5 * y5), 3)) / (Math.Pow(Math.Cos(Math.Pow(x5, 3) * Math.Pow(c5, 2)), 4))}",
                                "Задание №5",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tbx5.Text = string.Empty;
                Tby5.Text = string.Empty;
                Tbc5.Text = string.Empty;
                Tbz5.Text = string.Empty;

            }
        }

        private void Btnw5_Click(object sender, RoutedEventArgs e)
        {
            if (window6 == null)
            {
                window6 = new Window6();
                window6.Show();
            }
            else window6.Activate();

        }
    }
}
