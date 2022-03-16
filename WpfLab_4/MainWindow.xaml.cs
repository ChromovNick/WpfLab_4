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

namespace WpfLab_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDouble = rateDollar*sumDollar;
            ressum.Text = resDouble.ToString();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuros = Convert.ToDouble(rate1.Text);
            double sumEuros = Convert.ToDouble(sum1.Text);
            double resDouble1 = rateEuros * sumEuros;
            ressum1.Text = resDouble1.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGrivn = Convert.ToDouble(rate2.Text);
            double sumGrivn = Convert.ToDouble(sum2.Text);
            double resDouble2 = rateGrivn * sumGrivn;
            ressum2.Text = resDouble2.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDram = Convert.ToDouble(rate3.Text);
            double sumDram = Convert.ToDouble(sum3.Text);
            double resDouble3 = rateDram * sumDram;
            ressum3.Text = resDouble3.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double rateInches = Convert.ToDouble(distance.Text);
            double resDistance = rateInches/39.37;
            result.Text = resDistance.ToString("#.##");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double rateInches = Convert.ToDouble(distance1.Text);
            double resDistance = rateInches / 3.281;
            result1.Text = resDistance.ToString("#.##");
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double rateInches = Convert.ToDouble(distance2.Text);
            double resDistance = rateInches * 1609.34;
            result2.Text = resDistance.ToString("#.##");
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double rateInches = Convert.ToDouble(distance3.Text);
            double resDistance = rateInches * 1066.8;
            result3.Text = resDistance.ToString("#.##");
        }
    }
}
