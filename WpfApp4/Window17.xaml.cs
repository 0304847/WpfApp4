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
    /// Логика взаимодействия для Window17.xaml
    /// </summary>
    public partial class Window17 : Window
    {
        public static Window18 window18;
        public Window17()
        {
            InitializeComponent();
        }

        private void BtnTasck17_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tby17.Text) || string.IsNullOrEmpty(Tba17.Text) || string.IsNullOrEmpty(Tbb17.Text)|| string.IsNullOrEmpty(Tbx17.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №17",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tby17.Text = string.Empty;
                Tba17.Text = string.Empty;
                Tbb17.Text = string.Empty;
                Tbx17.Text = string.Empty;
            }
            else
            {
                double x17 = Convert.ToDouble(Tbx17.Text), y17 = Convert.ToDouble(Tby17.Text), a17 = Convert.ToDouble(Tba17.Text),b17= Convert.ToDouble(Tbb17.Text);

                MessageBox.Show($"  T17 ={(Math.Sqrt(x17 + b17 - a17) + Math.Log10(y17)) / (Math.Atan(b17 + a17))}",
                                "Задание №17",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tby17.Text = string.Empty;
                Tba17.Text = string.Empty;
                Tbb17.Text = string.Empty;
                Tbx17.Text = string.Empty;


            }
        }

        private void Btnw17_Click(object sender, RoutedEventArgs e)
        {

            if (window18 == null)
            {
                window18 = new Window18();
                window18.Show();
            }
            else window18.Activate();
        }
    }
}
