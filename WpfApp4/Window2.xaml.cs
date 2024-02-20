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
using WpfApp4;

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    
    {
        public static Window3 window3; 
        public Window2()
        {
            InitializeComponent();
        }

        private void BtnTasck2_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tbt2.Text) || string.IsNullOrEmpty(Tbc2.Text) || string.IsNullOrEmpty(Tbx2.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №2",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tbx2.Text = string.Empty;
                Tbt2.Text = string.Empty;
                Tbc2.Text = string.Empty;
            }
            else
            {
                double x2 = Convert.ToDouble(Tbx2.Text), c2 = Convert.ToDouble(Tbc2.Text), t2 = Convert.ToDouble(Tbt2.Text);

                MessageBox.Show($" L2 = {Math.Pow(Math.Tan(c2), 2) + (2 * Math.Pow(x2, 2) + 5) / (Math.Sqrt(c2 + t2))}",
                                "Задание №2",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tbx2.Text = string.Empty;
                Tbt2.Text = string.Empty;
                Tbc2.Text = string.Empty;

            }
        }

        private void Btnw3_Click(object sender, RoutedEventArgs e)
        {
                  if (window3 == null)
                  {
                        window3 = new Window3();
                         window3.Show();
                  }
                  else window3.Activate();

        }
    }
}
