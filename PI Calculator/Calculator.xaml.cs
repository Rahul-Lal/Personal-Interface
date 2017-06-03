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
using PI_Calculator.Classes;
using PI_Calculator.Properties;

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
            WindowTitle = "Personal Interface | Calculator";
        }

        // answer = firstValue + or - or * or / secondValue
        double firstValue, secondValue, answer;
        calculateFunctions cf = new calculateFunctions();

        int arthiSelected;
        int[] arthiSelection = {1, 2, 3, 4};
        /*
            * 1 = addition
            * 2 = subtraction
            * 3 = multiplication
            * 4 = division
         */

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
            txtOutput.Text = "";
        }

        private void btnClearAll_Click(object sender, RoutedEventArgs e)
        {
            firstValue = 0.00;
            secondValue = 0.00;
            answer = 0.00;
            txtOutput.Text = "";
        }

        private void btnAddition_Click(object sender, RoutedEventArgs e)
        {
            arthiSelected = 1;
            firstValue = double.Parse(txtOutput.Text);
            txtOutput.Clear();
        }

        private void btnSubtraction_Click(object sender, RoutedEventArgs e)
        {
            arthiSelected = 2;
            firstValue = double.Parse(txtOutput.Text);
            txtOutput.Clear();
        }

        private void btnMultiplication_Click(object sender, RoutedEventArgs e)
        {
            arthiSelected = 3;
            firstValue = double.Parse(txtOutput.Text);
            txtOutput.Clear();
        }

        private void btnDivision_Click(object sender, RoutedEventArgs e)
        {
            arthiSelected = 4;
            firstValue = double.Parse(txtOutput.Text);
            txtOutput.Clear();
        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            if ((arthiSelected == null) || (txtOutput.Text == "") || (firstValue == null) || (secondValue == null))
            {
                MessageBox.Show("You did not select a operation");
            }
            else
            {
                secondValue = double.Parse(txtOutput.Text);
                txtOutput.Clear();

                if (arthiSelected == arthiSelection[0])
                {
                    cf.additionFunction(firstValue, secondValue, answer);
                    txtOutput.Text = cf.overallAnswer.ToString();
                }
                else if (arthiSelected == arthiSelection[1])
                {
                    cf.subtractionFunction(firstValue, secondValue, answer);
                    txtOutput.Text = cf.overallAnswer.ToString();
                }
                else if (arthiSelected == arthiSelection[2])
                {
                    cf.multiplicationFuction(firstValue, secondValue, answer);
                    txtOutput.Text = cf.overallAnswer.ToString();
                }
                else if (arthiSelected == arthiSelection[3])
                {
                    cf.divisionFunction(firstValue, secondValue, answer);
                    txtOutput.Text = cf.overallAnswer.ToString();
                }
                else
                {
                    MessageBox.Show("You did not select a operation!");
                }
            }
        }

        private void btnPI_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text = Math.PI.ToString();
        }
    }
}
