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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PR1_Kiku_Khamukov_322
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            double x;
            double y;

            if (double.TryParse(InputX.Text, out x) && double.TryParse(InputY.Text, out y))
            {
                double f_x = 0;

                
                if (shRadioButton.IsChecked == true)
                {
                    f_x = Math.Sinh(x); 
                }
                else if (x2RadioButton.IsChecked == true)
                {
                    f_x = Math.Pow(x, 2);
                }
                else if (exRadioButton.IsChecked == true)
                {
                    f_x = Math.Exp(x); 
                }

                double c;


                if (x * y > 0)
                {
                    c = Math.Pow(f_x + y, 2) - Math.Sqrt(f_x * y);
                }
                else if (x * y < 0)
                {
                    c = Math.Pow(f_x + y, 2) - Math.Sqrt(Math.Abs(f_x * y));
                }
                else // x * y == 0
                {
                    c = Math.Pow(f_x + y, 2) + 1;
                }

                OutputResult.Text = c.ToString();
            }
            else
            {
                MessageBox.Show("Введите корректные значения для x и y.");
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            InputX.Clear();
            InputY.Clear();
            OutputResult.Clear();
            shRadioButton.IsChecked = false;
            x2RadioButton.IsChecked = false;
            exRadioButton.IsChecked = false;
        }
    }
}