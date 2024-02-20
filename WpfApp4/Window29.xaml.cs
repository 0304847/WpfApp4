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
    /// Логика взаимодействия для Window29.xaml
    /// </summary>
    public partial class Window29 : Window
    {
        public static Window30 window30;
        public Window29()
        {
            InitializeComponent();
        }

        private void BtnTasck29_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tby29.Text) || string.IsNullOrEmpty(Tbd29.Text) || string.IsNullOrEmpty(Tbx29.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №29",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tby29.Text = string.Empty;
                Tbd29.Text = string.Empty;
                Tbx29.Text = string.Empty;

            }
            else
            {
                double x29 = Convert.ToDouble(Tbx29.Text), y29 = Convert.ToDouble(Tby29.Text), d29 = Convert.ToDouble(Tbd29.Text);

                MessageBox.Show($"    R29 ={(Math.Pow(Math.Cos(y29), 2) + 2.4 * d29) / (Math.Exp(y29) + Math.Log10(Math.Pow(Math.Sin(x29), 2) + 6))}",
                                "Задание №29",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tby29.Text = string.Empty;
                Tbx29.Text = string.Empty;
                Tbd29.Text = string.Empty;

            }
        }

        private void Btnw29_Click(object sender, RoutedEventArgs e)
        {
            if (window30 == null)
            {
                window30 = new Window30();
                window30.Show();
            }
            else window30.Activate();
        }
    }
}
