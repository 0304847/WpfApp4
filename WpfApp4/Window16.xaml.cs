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
    /// Логика взаимодействия для Window16.xaml
    /// </summary>
    public partial class Window16 : Window
    {
        public static Window17 window17;
        public Window16()
        {
            InitializeComponent();
        }

        private void BtnTasck16_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(Tbt16.Text) ||string.IsNullOrEmpty(Tby16.Text)|| string.IsNullOrEmpty(Tbx16.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №16",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tbt16.Text = string.Empty;
                Tby16.Text = string.Empty;
               Tbx16.Text = string.Empty;
            }
            else
            {
                double x16 = Convert.ToDouble(Tbx16.Text), y16 = Convert.ToDouble(Tby16.Text), t16= Convert.ToDouble(Tbt16.Text);

                MessageBox.Show($"  P16 ={(Math.Pow(Math.Sin(x16), 3) + Math.Log10(2 * y16 + 3 * x16)) / (Math.Pow(t16, 2) + Math.Sqrt(x16))}",
                                "Задание №16",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tbt16.Text = string.Empty;
                Tbx16.Text = string.Empty;
               Tby16.Text = string.Empty;

            }
        }

        private void Btnw16_Click(object sender, RoutedEventArgs e)
        {
            if (window17 == null)
            {
                window17 = new Window17();
                window17.Show();
            }
            else window17.Activate();
        }
    }
}
