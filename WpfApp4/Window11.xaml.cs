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
    /// Логика взаимодействия для Window11.xaml
    /// </summary>
    public partial class Window11 : Window
    {
        public static Window12 window12;
        public Window11()
        {
            InitializeComponent();
        }

        private void BtnTasck11_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tby11.Text) | string.IsNullOrEmpty(Tbx11.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №11",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tby11.Text = string.Empty;
                Tbx11.Text = string.Empty;
            }
            else
            {
                double x11 = Convert.ToDouble(Tbx11.Text), y11 = Convert.ToDouble(Tby11.Text);

                MessageBox.Show($" I11 ={(2.33 * Math.Log10(Math.Sqrt(1 + Math.Pow(Math.Cos(y11), 2)))) / (Math.Exp(y11) + Math.Pow(Math.Sin(x11), 2))}",
                                "Задание №11",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tby11.Text = string.Empty;
                Tbx11.Text = string.Empty;

            }

        }

        private void Btnw11_Click(object sender, RoutedEventArgs e)
        {
            if (window12 == null)
            {
                window12 = new Window12();
                window12.Show();
            }
            else window12.Activate();
        }
    }
}
