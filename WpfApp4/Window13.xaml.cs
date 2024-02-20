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
    /// Логика взаимодействия для Window13.xaml
    /// </summary>
    public partial class Window13 : Window
    {
        public static Window14 window14;
        public Window13()
        {
            InitializeComponent();
        }

        private void BtnTasck13_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tbb13.Text) || string.IsNullOrEmpty(Tbx13.Text) || string.IsNullOrEmpty(Tba13.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №13",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tbb13.Text = string.Empty;
                Tbx13.Text = string.Empty;
                Tba13.Text = string.Empty;
            }
            else
            {
                double x13 = Convert.ToDouble(Tbx13.Text), a13 = Convert.ToDouble(Tba13.Text), b13 = Convert.ToDouble(Tbb13.Text);

                MessageBox.Show($"   R13 ={(a13 / (x13 - a13)) + ((Math.Pow(b13, x13) + Math.Pow(Math.Cos(x13), 3)) / (Math.Pow(Math.Log(a13), 3) + 4.5))}",
                                "Задание №13",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tbx13.Text = string.Empty;
                Tba13.Text = string.Empty;
                Tbb13.Text = string.Empty;

            }
        }

        private void Btnw13_Click(object sender, RoutedEventArgs e)
        {
            if (window14 == null)
            {
                window14 = new Window14();
                window14.Show();
            }
            else window14.Activate();
        }
    }
}
