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

namespace PI_Calculator
{
    /// <summary>
    /// Interaction logic for Calculator.xaml
    /// </summary>
    public partial class Calculator : Page
    {
        public Calculator()
        {
            InitializeComponent();
        }

        public string num1, num2;
        public int[] functionNum = { 1, 2, 3, 4 };

        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "1";
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "2";
        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "3";
        }

        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "4";
        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "5";
        }

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "6";
        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "7";
        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "8";
        }

        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "9";
        }

        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "0";
        }

        private void btnClearEntry_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "";
        }

        private void btnClearAll_Click(object sender, RoutedEventArgs e)
        {
            num1 = "";
            num2 = "";
            txtOutput.Text += "";
        }
    }
}
