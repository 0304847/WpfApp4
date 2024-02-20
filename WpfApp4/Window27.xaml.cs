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
    /// Логика взаимодействия для Window27.xaml
    /// </summary>
    public partial class Window27 : Window
    {
        public static Window28 window28;
        public Window27()
        {
            InitializeComponent();
        }

        private void BtnTasck27_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tbc27.Text) || string.IsNullOrEmpty(Tbx27.Text) || string.IsNullOrEmpty(Tby27.Text)|| string.IsNullOrEmpty(Tba27.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №27",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tba27.Text = string.Empty;
                Tby27.Text = string.Empty;
                Tbx27.Text = string.Empty;
                Tbc27.Text = string.Empty;

            }
            else
            {
                double x27 = Convert.ToDouble(Tbx27.Text), y27 = Convert.ToDouble(Tby27.Text), a27 = Convert.ToDouble(Tba27.Text), c27 = Convert.ToDouble(Tbc27.Text);

                MessageBox.Show($"    P27 ={(Math.Pow(a27, 5) + Math.Acos(a27 + Math.Pow(x27, 3)) - Math.Pow(Math.Sin(y27 - c27), 4)) / (Math.Pow(Math.Sin(x27 + y27), 3) + Math.Abs(x27 + y27))}",
                                "Задание №27",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tba27.Text = string.Empty;
                Tbc27.Text = string.Empty;
                Tby27.Text = string.Empty;
                Tbx27.Text = string.Empty;

            }
        }

        private void Btnw27_Click(object sender, RoutedEventArgs e)
        {
            if (window28 == null)
            {
                window28 = new Window28();
                window28.Show();
            }
            else window28.Activate();
        }
    }
}
