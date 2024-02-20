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
    /// Логика взаимодействия для Window7xaml.xaml
    /// </summary>
    public partial class Window7xaml : Window
    {
        public static Window8 window8;
        public Window7xaml()
        {
            InitializeComponent();
        }

        private void BtnTasck7_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tby7.Text) || string.IsNullOrEmpty(Tbx7.Text)|| string.IsNullOrEmpty(Tba7.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №7",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tbx7.Text = string.Empty;
                Tby7.Text = string.Empty;
                Tba7.Text = string.Empty;
                
            }
            else
            {
                double x7 = Convert.ToDouble(Tbx7.Text), y7 = Convert.ToDouble(Tby7.Text), a7 = Convert.ToDouble(Tba7.Text);

                MessageBox.Show($"D7 = {(Math.Cos(Math.Pow(x7, 3) + 6) - Math.Sin(y7 - a7)) / (Math.Log10(Math.Pow(x7, 4)) - 2 * Math.Pow(Math.Sin(x7), 5))}",
                                "Задание №7",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tbx7.Text = string.Empty;
                Tby7.Text = string.Empty;
                Tba7.Text = string.Empty;   

            }
        }
        private void Btnw7_Click(object sender, RoutedEventArgs e)
        {
            if (window8 == null)
            {
                window8 = new Window8();
                window8.Show();
            }
            else window8.Activate();
        }
    }
}
