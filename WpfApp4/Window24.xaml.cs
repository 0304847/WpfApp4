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
    /// Логика взаимодействия для Window24.xaml
    /// </summary>
    public partial class Window24 : Window
    {
        public static Window25 window25;
        public Window24()
        {
            InitializeComponent();
        }

        private void BtnTasck24_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tbb24.Text) || string.IsNullOrEmpty(Tbx24.Text)|| string.IsNullOrEmpty(Tba24.Text)|| string.IsNullOrEmpty(Tbz24.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №24",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tbb24.Text = string.Empty;
                Tbx24.Text = string.Empty;
                Tba24.Text = string.Empty;
                Tbz24.Text = string.Empty;

            }
            else
            {
                double b24 = Convert.ToDouble(Tbb24.Text), x24 = Convert.ToDouble(Tbx24.Text), a24 = Convert.ToDouble(Tba24.Text), z24=Convert.ToDouble(Tbz24.Text);

                MessageBox.Show($"   F24 ={(Math.Pow(Math.Cos(b24 * Math.Pow(x24, 5)), 7)) - (Math.Sin(Math.Pow(a24, 2)) + Math.Cos(Math.Pow(x24, 3) + Math.Pow(z24, 5) - Math.Pow(a24, 2))) / (Math.Asin(Math.Pow(a24, 2)) + Math.Acos(Math.Pow(x24, 7) - Math.Pow(a24, 2)))}",
                                "Задание №24",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tbb24.Text = string.Empty;
                Tbx24.Text = string.Empty;
                Tba24.Text = string.Empty;
                Tbz24.Text = string.Empty;


            }
        }

        private void Btnw24_Click(object sender, RoutedEventArgs e)
        {
            if (window25 == null)
            {
                window25 = new Window25();
                window25.Show();
            }
            else window25.Activate();
        }
    }
}
