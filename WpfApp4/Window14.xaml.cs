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
    /// Логика взаимодействия для Window14.xaml
    /// </summary>
    public partial class Window14 : Window
    {
        public static Window15 window15;
        public Window14()
        {
            InitializeComponent();
        }

        private void BtnTasck14_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tbx14.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №14",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tbx14.Text = string.Empty;
            }
            else
            {
                double x14 = Convert.ToDouble(Tbx14.Text);

                MessageBox.Show($"  R14 ={(Math.Sin(Math.Pow(Math.Pow(x14, 2) + 4,3))+ 4.3) / (Math.Pow(Math.Sin(Math.Pow(x14, 4)), 3))}",
                                "Задание №14",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tbx14.Text = string.Empty;

            }
        }

        private void Btnw14_Click(object sender, RoutedEventArgs e)
        {
            if (window15 == null)
            {
                window15 = new Window15();
                window15.Show();
            }
            else window15.Activate();
        }
    }
}
