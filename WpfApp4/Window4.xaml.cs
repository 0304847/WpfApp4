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
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public static Window5 window5;
        public Window4()
        {
            InitializeComponent();
        }

        private void BtnTasck4_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tby4.Text) || string.IsNullOrEmpty(Tbx4.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №4",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tby4.Text = string.Empty;
                Tbx4.Text = string.Empty;
            }
            else
            {
                double x4 = Convert.ToDouble(Tbx4.Text), y4 = Convert.ToDouble(Tby4.Text);

                MessageBox.Show($"F4 = {(Math.Sqrt(Math.Pow(2 + y4, 2) + Math.Pow(Math.Sqrt(Math.Sin(y4 + 5)), 4))) / (Math.Log10(x4 + 1) - Math.Pow(y4, 3))}",
                                "Задание №4",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tbx4.Text = string.Empty;
                Tby4.Text = string.Empty;
            }

        }

        private void Btnw4_Click(object sender, RoutedEventArgs e)
        {
            if (window5 == null)
            {
                window5 = new Window5();
                window5.Show();
            }
            else window5.Activate();

        }
    }
}
