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
    /// Логика взаимодействия для Window23.xaml
    /// </summary>
    public partial class Window23 : Window
    {
        public static Window24 window24;
        public Window23()
        {
            InitializeComponent();
        }

        private void BtnTasck23_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tba23.Text) || string.IsNullOrEmpty(Tbb23.Text) || string.IsNullOrEmpty(Tbz23.Text)|| string.IsNullOrEmpty(Tbx23.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №23",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tba23.Text = string.Empty;
                Tbb23.Text = string.Empty;
                Tbz23.Text = string.Empty;
                Tbx23.Text = string.Empty;
            }
            else
            {
                double a23 = Convert.ToDouble(Tba23.Text), x23 = Convert.ToDouble(Tbx23.Text), z23 = Convert.ToDouble(Tbz23.Text), b23 = Convert.ToDouble(Tbx23.Text);

                MessageBox.Show($"  F23 ={(Math.Sqrt(Math.Abs(x23) + Math.Pow(Math.Cos(x23), 4) + Math.Pow(z23, 4))) / (Math.Log10(x23) - Math.Asin(b23 * x23 - a23))}",
                                "Задание №23",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tba23.Text = string.Empty;
                Tbb23.Text = string.Empty;
                Tbz23.Text = string.Empty;
                Tbx23.Text = string.Empty;

            }
        }

        private void Btnw23_Click(object sender, RoutedEventArgs e)
        {
            if (window24 == null)
            {
                window24 = new Window24();
                window24.Show();
            }
            else window24.Activate();
        }
    }
}
