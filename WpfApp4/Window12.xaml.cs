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
    /// Логика взаимодействия для Window12.xaml
    /// </summary>
    public partial class Window12 : Window
    {
        public static Window13 window13;
        public Window12()
        {
            InitializeComponent();
        }

        private void BtnTasck12_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tba12.Text) || string.IsNullOrEmpty(Tby12.Text) || string.IsNullOrEmpty(Tbx12.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №12",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tba12.Text = string.Empty;
                Tby12.Text = string.Empty;
                Tbx12.Text = string.Empty;
            }
            else
            {
                double x12 = Convert.ToDouble(Tbx12.Text), y12 = Convert.ToDouble(Tby12.Text), a12 = Convert.ToDouble(Tba12.Text);

                MessageBox.Show($"  G12 ={(Math.Pow(Math.Cos(Math.Abs(y12 + x12)), 3) - (x12 + y12)) / (Math.Pow(Math.Atan(x12 + a12), 4) * Math.Pow(x12, 5))}",
                                "Задание №12",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tbx12.Text = string.Empty;
                Tba12.Text = string.Empty;
                Tby12.Text = string.Empty;

            }
        }

        private void Btnw12_Click(object sender, RoutedEventArgs e)
        {
            if (window13 == null)
            {
                window13 = new Window13();
                window13.Show();
            }
            else window13.Activate();
        }
    }

}