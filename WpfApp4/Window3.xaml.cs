using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

    public partial class Window3 : Window
    {
        public static Window4 window4;
        public Window3()
        {
            InitializeComponent();
        }


        private void BtnTasck3_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tbh3.Text) || string.IsNullOrEmpty(Tby3.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №3",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tbh3.Text = string.Empty;
                Tby3.Text = string.Empty;
            }
            else
            {
                double h3 = Convert.ToDouble(Tbh3.Text), y3 = Convert.ToDouble(Tby3.Text);

                MessageBox.Show($"A3 = {(Math.Tan(Math.Pow(y3, 3) - Math.Pow(h3, 4)) + Math.Pow(h3, 2)) / (Math.Pow(Math.Sin(h3), 3) + y3)}",
                                "Задание №3",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tbh3.Text = string.Empty;
                Tby3.Text = string.Empty;
            }

        }
        private void Btnw4_Click(object sender, RoutedEventArgs e)
        {
            if (window4 == null)
            {
                window4 = new Window4();
                window4.Show();
            }
            else window4.Activate();
        }
    }
}
    