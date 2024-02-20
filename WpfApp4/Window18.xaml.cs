using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
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
    /// Логика взаимодействия для Window18.xaml
    /// </summary>
    public partial class Window18 : Window
    {
        public static Window19 window19;
        public Window18()
        {
            InitializeComponent();
        }

        private void BtnTasck18_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tbt18.Text) || string.IsNullOrEmpty(Tby18.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №18",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tbt18.Text = string.Empty;
                Tby18.Text = string.Empty;
            }
            else
            {
                double t18 = Convert.ToDouble(Tbt18.Text), y18 = Convert.ToDouble(Tby18.Text);

                MessageBox.Show($"  S18 ={(4.351 * Math.Pow(y18, 3) + 2 * t18 * Math.Log10(t18)) / (Math.Sqrt(Math.Cos(2 * y18) + 4.351))}",
                                "Задание №18",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tbt18.Text = string.Empty;
                Tby18.Text = string.Empty;


            }

         
            
                
        }

        private void Btnw18_Click(object sender, RoutedEventArgs e)
        {
            if (window19 == null)
            {
                window19 = new Window19();
                window19.Show();
            }
            else window19.Activate();
        }
    
    }
}
