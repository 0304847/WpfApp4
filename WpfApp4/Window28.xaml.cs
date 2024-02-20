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
    /// Логика взаимодействия для Window28.xaml
    /// </summary>
    public partial class Window28 : Window
    {
        public static Window29 window29;
        public Window28()
        {
            InitializeComponent();
        }

        private void BtnTasck28_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tbc28.Text) || string.IsNullOrEmpty(Tbx28.Text) || string.IsNullOrEmpty(Tby28.Text) || string.IsNullOrEmpty(Tbz28.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №28",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tbz28.Text = string.Empty;
                Tby28.Text = string.Empty;
                Tbx28.Text = string.Empty;
                Tbc28.Text = string.Empty;

            }
            else
            {
                double x28 = Convert.ToDouble(Tbx28.Text), y28 = Convert.ToDouble(Tby28.Text), z28 = Convert.ToDouble(Tbz28.Text), c28 = Convert.ToDouble(Tbc28.Text);

                MessageBox.Show($"  G28 ={(Math.Tan(Math.Pow(x28, 4) - 6) - Math.Pow(Math.Cos(z28 + Math.Pow(x28, 3) * y28), 3 * x28)) / (Math.Pow(Math.Cos(Math.Pow(x28, 3) * Math.Pow(c28, 2)), 2))}",
                                "Задание №28",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tbz28.Text = string.Empty;
                Tbc28.Text = string.Empty;
                Tby28.Text = string.Empty;
                Tbx28.Text = string.Empty;

            }
        }

        private void Btnw28_Click(object sender, RoutedEventArgs e)
        {
            if (window29 == null)
            {
                window29 = new Window29();
                window29.Show();
            }
            else window29.Activate();
        }
    }
}
