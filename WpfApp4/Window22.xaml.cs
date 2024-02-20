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
    /// Логика взаимодействия для Window22.xaml
    /// </summary>
    public partial class Window22 : Window
    {
        public static Window23 window23;
        public Window22()
        {
            InitializeComponent();
        }

        private void BtnTasck22_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tby22.Text) || string.IsNullOrEmpty(Tbx22.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №22",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tby22.Text = string.Empty;
                Tbx22.Text = string.Empty;
            }
            else
            {
                double y22 = Convert.ToDouble(Tby22.Text), x22 = Convert.ToDouble(Tbx22.Text);

                MessageBox.Show($"  F22 ={Math.Cos(Math.Pow(x22, 2) + 2) + (3.5 * Math.Pow(x22, 2) + 1) / (Math.Pow(Math.Cos(y22), 2))}",
                                "Задание №22",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tby22.Text = string.Empty;
                Tbx22.Text = string.Empty;


            }
        }

        private void Btnw22_Click(object sender, RoutedEventArgs e)
        {
            if (window23 == null)
            {
                window23 = new Window23();
                window23.Show();
            }
            else window23.Activate();
        }
    }
}
