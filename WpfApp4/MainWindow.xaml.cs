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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Window2 window2;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnTasck1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tbc1.Text) || string.IsNullOrEmpty(Tba1.Text) || string.IsNullOrEmpty(Tbx1.Text) || string.IsNullOrEmpty(Tbe1.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №1",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tbx1.Text = string.Empty;
                Tba1.Text = string.Empty;
                Tbc1.Text = string.Empty;
                Tbe1.Text = string.Empty;
            }
            else
            {
                double x1 = Convert.ToDouble(Tbx1.Text), a1 = Convert.ToDouble(Tba1.Text), c1 = Convert.ToDouble(Tbc1.Text), e1 = Convert.ToDouble(Tbe1.Text);

                MessageBox.Show($"L1 = {((Math.Sqrt(Math.Exp(x1) - Math.Pow(Math.Cos(Math.Pow(x1, 2) * Math.Pow(a1, 5)), 4)) + Math.Pow(Math.Atan(a1 - Math.Pow(x1, 5)), 4)) / (Math.Pow(Math.Sqrt(Math.Abs(a1 + x1 * Math.Pow(c1, 4))), e1)))}",
                                "Задание №1",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tbx1.Text = string.Empty;
                Tba1.Text = string.Empty;
                Tbc1.Text = string.Empty;
                Tbe1.Text = string.Empty;

            }
        }

        private void Btnw2_Click(object sender, RoutedEventArgs e)
        {
            if (window2 == null)
            {
                window2 = new Window2();
                window2.Show();
            }
            else window2.Activate();
                    
        }
    }
}
