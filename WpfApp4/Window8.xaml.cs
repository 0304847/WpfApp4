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
    /// Логика взаимодействия для Window8.xaml
    /// </summary>
    public partial class Window8 : Window
    {
        public static Window9 window9;
        public Window8()
        {
            InitializeComponent();
        }

        private void BtnTasck8_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tbx8.Text) || string.IsNullOrEmpty(Tby8.Text) || string.IsNullOrEmpty(Tbc8.Text) || string.IsNullOrEmpty(Tba8.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №8",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tbx8.Text = string.Empty;
                Tby8.Text = string.Empty;
                Tbc8.Text = string.Empty;
                Tba8.Text = string.Empty;
            }
            else
            {
                double x8 = Convert.ToDouble(Tbx8.Text), a8 = Convert.ToDouble(Tba8.Text), y8 = Convert.ToDouble(Tby8.Text), c8 = Convert.ToDouble(Tbc8.Text);

                MessageBox.Show($" P8 ={(Math.Pow(a8, 5) + Math.Pow(Math.Sin(y8 - c8), 4)) / (Math.Pow(Math.Sin(x8 + y8), 3) + Math.Abs(x8 - y8))}",
                                "Задание №8",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tbx8.Text = string.Empty;
                Tby8.Text = string.Empty;
                Tbc8.Text = string.Empty;
                Tba8.Text = string.Empty;

            }

        }

        private void Btnw8_Click(object sender, RoutedEventArgs e)
        {
            if (window9 == null)
            {
                window9 = new Window9();
                window9.Show();
            }
            else window9.Activate();
        }
    }
}
