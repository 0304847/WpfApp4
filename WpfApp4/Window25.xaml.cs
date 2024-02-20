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
    /// Логика взаимодействия для Window25.xaml
    /// </summary>
    public partial class Window25 : Window
    {
        public static Window26 window26;
        public Window25()
        {
            InitializeComponent();
        }

        private void BtnTasck25_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tbx25.Text) || string.IsNullOrEmpty(Tby25.Text) || string.IsNullOrEmpty(Tba25.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №25",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tbx25.Text = string.Empty;
                Tby25.Text = string.Empty;
                Tba25.Text = string.Empty;

            }
            else
            {
                double x25 = Convert.ToDouble(Tbx25.Text), y25 = Convert.ToDouble(Tby25.Text), a25 = Convert.ToDouble(Tba25.Text);

                MessageBox.Show($"   J25 ={(Math.Pow(Math.Tanh(Math.Pow(a25, 3)), 3) + Math.Pow(Math.Atan(a25), 2)) / (Math.Sqrt(Math.Pow(y25, Math.Tan(x25))))}",
                                "Задание №25",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tbx25.Text = string.Empty;
                Tba25.Text = string.Empty;
                Tby25.Text = string.Empty;

            }
        }

        private void Btnw25_Click(object sender, RoutedEventArgs e)
        {
            if (window26 == null)
            {
                window26 = new Window26();
                window26.Show();
            }
            else window26.Activate();
        }
    }
}
