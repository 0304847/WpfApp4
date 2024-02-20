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
    /// Логика взаимодействия для Window10.xaml
    /// </summary>
    public partial class Window10 : Window
    {
        public static Window11 window11;
        public Window10()
        {
            InitializeComponent();
        }

        private void BtnTasck10_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tby10.Text)| string.IsNullOrEmpty(Tbx10.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №10",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tby10.Text = string.Empty;
                Tbx10.Text = string.Empty;
            }
            else
            {
                double x10 = Convert.ToDouble(Tbx10.Text), y10 = Convert.ToDouble(Tby10.Text);

                MessageBox.Show($" U10 ={(Math.Exp(Math.Pow(x10, 3)) + Math.Pow(Math.Cos(x10 - 4), 2) / (Math.Atan(x10) + 5.2 * y10))}",
                                "Задание №10",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tby10.Text = string.Empty;
                Tbx10.Text = string.Empty;

            }
        }

        private void Btnw10_Click(object sender, RoutedEventArgs e)
        {
            if (window11 == null)
            {
                window11= new Window11();
                window11.Show();
            }
            else window11.Activate();
        }
    }
}
