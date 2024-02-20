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
    /// Логика взаимодействия для Window30.xaml
    /// </summary>
    public partial class Window30 : Window
    {
        public Window30()
        {
            InitializeComponent();
        }

        private void BtnTasck30_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tbx30.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №30",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tbx30.Text = string.Empty;
            }
            else
            {
                double x30 = Convert.ToDouble(Tbx30.Text);

                MessageBox.Show($" K30 ={(Math.Sqrt(Math.Pow(3 + x30, 6) - Math.Log10(x30))) / Math.Exp(0) + Math.Asin(6 * Math.Pow(x30, 2))}", 
                                "Задание №30",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tbx30.Text = string.Empty;
            }
        }
    }
}
