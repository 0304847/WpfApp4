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
    /// Логика взаимодействия для Window15.xaml
    /// </summary>
    public partial class Window15 : Window
    {
        public static Window16 window16;
        public Window15()
        {
            InitializeComponent();
        }

        private void BtnTasck15_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tbm15.Text) ||string.IsNullOrEmpty(Tby15.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №15",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tbm15.Text = string.Empty;
                Tby15.Text = string.Empty;
            }
            else
            {
                double m15 = Convert.ToDouble(Tbm15.Text), y15 = Convert.ToDouble(Tby15.Text);

                MessageBox.Show($" N15 ={(Math.Pow(m15, 2) + 2.8 * m15 + 0.355) / (Math.Cos(2 * y15) + 3.6)}",
                                "Задание №15",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tbm15.Text = string.Empty;
                Tby15.Text = string.Empty;

            }
        }

        private void Btnw15_Click(object sender, RoutedEventArgs e)
        {

            if (window16 == null)
            {
                window16 = new Window16();
                window16.Show();
            }
            else window16.Activate();
        }
    }
}
