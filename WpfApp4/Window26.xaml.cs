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
    /// Логика взаимодействия для Window26.xaml
    /// </summary>
    public partial class Window26 : Window
    {
        public static Window27 window27;
        public Window26()
        {
            InitializeComponent();
        }

        private void BtnTasck26_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tbk26.Text) || string.IsNullOrEmpty(Tby26.Text) || string.IsNullOrEmpty(Tbx26.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №26",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tbk26.Text = string.Empty;
                Tby26.Text = string.Empty;
                Tbx26.Text = string.Empty;

            }
            else
            {
                double x26 = Convert.ToDouble(Tbx26.Text), y26 = Convert.ToDouble(Tby26.Text), k26 = Convert.ToDouble(Tbk26.Text);

                MessageBox.Show($"   U26 ={(Math.Log10(Math.Pow(x26, 3) + y26) - Math.Pow(y26, 4)) / (Math.Exp(y26) + 5.4 * Math.Pow(k26, 3))}",
                                "Задание №26",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tbk26.Text = string.Empty;
                Tbk26.Text = string.Empty;
                Tby26.Text = string.Empty;

            }
        }

        private void Btnw26_Click(object sender, RoutedEventArgs e)
        {
            if (window27 == null)
            {
                window27 = new Window27();
                window27.Show();
            }
            else window27.Activate();
        }
    }
}
