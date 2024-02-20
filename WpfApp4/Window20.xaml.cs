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
    /// Логика взаимодействия для Window20.xaml
    /// </summary>
    public partial class Window20 : Window
    {
        public static Window21 window21;
        public Window20()
        {
            InitializeComponent();
        }

        private void BtnTasck20_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tby20.Text) || string.IsNullOrEmpty(Tbx20.Text) || string.IsNullOrEmpty(Tbb20.Text) || string.IsNullOrEmpty(Tbc20.Text) || string.IsNullOrEmpty(Tba20.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №20",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tby20.Text = string.Empty;
                Tbx20.Text = string.Empty;
                Tbb20.Text = string.Empty;
                Tbc20.Text = string.Empty;
                Tba20.Text = string.Empty;
            }
            else
            {
                double y20= Convert.ToDouble(Tby20.Text), x20 = Convert.ToDouble(Tbx20.Text), a20 = Convert.ToDouble(Tbb20.Text), b20 = Convert.ToDouble(Tbc20.Text), c20 = Convert.ToDouble(Tba20.Text);

                MessageBox.Show($"     U20 ={(Math.Pow(Math.Tan(y20), 3) + Math.Pow(Math.Sin(x20 * Math.Sqrt(b20 - c20)), 5)) / (Math.Sqrt(a20 - b20 + c20))}",
                                "Задание №20",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tby20.Text = string.Empty;
                Tbx20.Text = string.Empty;
                Tbb20.Text = string.Empty;
                Tbc20.Text = string.Empty;
                Tba20.Text = string.Empty;



            }
        }

        private void Btnw20_Click(object sender, RoutedEventArgs e)
        {
            if (window21 == null)
            {
                window21= new Window21();
                window21.Show();
            }
            else window21.Activate();
        }
    }
}
