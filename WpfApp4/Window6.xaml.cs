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
    /// Логика взаимодействия для Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public static Window7xaml window7;
        public Window6()
        {
            InitializeComponent();
        }

        private void BtnTasck6_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tby6.Text) || string.IsNullOrEmpty(Tba6.Text) || string.IsNullOrEmpty(Tbb6.Text) || string.IsNullOrEmpty(Tbx6.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №6",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tba6.Text = string.Empty;
                Tby6.Text = string.Empty;
                Tbb6.Text = string.Empty;
                Tbx6.Text = string.Empty;
            }
            else
            {
                double x6 = Convert.ToDouble(Tbx6.Text), b6 = Convert.ToDouble(Tbb6.Text), y6 = Convert.ToDouble(Tby6.Text), a6 = Convert.ToDouble(Tba6.Text);

                MessageBox.Show($"K6 = {(Math.Sqrt(x6 + b6 - a6) + Math.Log10(y6)) / (Math.Atan(b6 + a6))}",
                                "Задание №6",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tbx6.Text = string.Empty;
                Tby6.Text = string.Empty;
                Tbb6.Text = string.Empty;
                Tba6.Text = string.Empty;

            }

        }

        private void Btnw6_Click(object sender, RoutedEventArgs e)
        {

            if (window7 == null)
            {
                window7 = new Window7xaml();
                window7.Show();
            }
            else window7.Activate();

        }
    }
}
