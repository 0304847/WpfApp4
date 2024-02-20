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
    /// Логика взаимодействия для Window19.xaml
    /// </summary>
    public partial class Window19 : Window
    {
        public static Window20 window20;
        public Window19()
        {
            InitializeComponent();
        }

        private void BtnTasck19_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tby19.Text) || string.IsNullOrEmpty(Tbb19.Text) || string.IsNullOrEmpty(Tba19.Text) || string.IsNullOrEmpty(Tbx19.Text)|| string.IsNullOrEmpty(TbK19.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №19",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tby19.Text = string.Empty;
                Tba19.Text = string.Empty;
                Tbb19.Text = string.Empty;
                Tbx19.Text = string.Empty;
                TbK19.Text = string.Empty;
            }
            else
            {
                double x19 = Convert.ToDouble(Tbx19.Text), y19 = Convert.ToDouble(Tby19.Text), a19 = Convert.ToDouble(Tba19.Text), b19 = Convert.ToDouble(Tbb19.Text), K19 = Convert.ToDouble(TbK19.Text);

                MessageBox.Show($"   D19 ={(Math.Pow(K19, -x19) - a19 * Math.Sqrt(6) - Math.Cos(3 * a19 * b19)) / (Math.Pow(Math.Sin(a19 * Math.Asin(x19) + Math.Log10(y19)), 2))}",
                                "Задание №19",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tby19.Text = string.Empty;
                Tba19.Text = string.Empty;
                Tbb19.Text = string.Empty;
                Tbx19.Text = string.Empty;
                TbK19.Text = string.Empty;
               


            }
        }

        private void Btnw19_Click(object sender, RoutedEventArgs e)
        {
            if (window20 == null)
            {
                window20 = new Window20();
                window20.Show();
            }
            else window20.Activate();
        }
    }
}
