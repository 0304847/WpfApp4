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
    /// Логика взаимодействия для Window9.xaml
    /// </summary>
    public partial class Window9 : Window
    {
        public static Window10 window10;
        public Window9()
        {
            InitializeComponent();
        }

        private void BtnTasck9_Click (object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tbd9.Text) || string.IsNullOrEmpty(Tbx9.Text) || string.IsNullOrEmpty(Tby9.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №9",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tbd9.Text = string.Empty;
                Tbx9.Text = string.Empty;
                Tby9.Text = string.Empty;
            }
            else
            {
                double d9 = Convert.ToDouble(Tbd9.Text), x9 = Convert.ToDouble(Tbx9.Text), y9 = Convert.ToDouble(Tby9.Text);

                MessageBox.Show($" R9 ={(Math.Pow(Math.Cos(y9), 3) + Math.Pow(2, x9) * d9) / (Math.Exp(y9) + Math.Log10(Math.Pow(Math.Sin(x9), 2) + 7.4))}",
                                "Задание №9",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tbd9.Text = string.Empty;
                Tbx9.Text = string.Empty;
                Tby9.Text = string.Empty;

            }
        }

        private void Btnw9_Click (object sender, RoutedEventArgs e)
        {
            if (window10 == null)
            {
                window10 = new Window10();
                window10.Show();
            }
            else window10.Activate();
        }


    }
}
