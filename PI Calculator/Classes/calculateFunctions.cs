using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Calculator.Classes
{
    public class calculateFunctions
    {
        public double overallAnswer; // Answer when press Equals button

        public void additionFunction(double num1, double num2, double answer) // If adding
        {
            answer = num1 + num2;
            overallAnswer = answer;
        }

        public void subtractionFunction(double num1, double num2, double answer)// If subtracting
        {
            answer = num1 - num2;
            overallAnswer = answer;
        }

        public void multiplicationFuction(double num1, double num2, double answer)// If multiplying
        {
            answer = num1 * num2;
            overallAnswer = answer;
        }

        public void divisionFunction(double num1, double num2, double answer)// If dividing
        {
            answer = num1 / num2;
            overallAnswer = answer;
        }

        public void trinityBarrier(double answer)// Obtaining value  that makes trinity
        {
            answer = 362880;
            double value = 1;

            for (double counter = 1; counter <= answer; counter++)
            {
                value = value * counter;
            }
            overallAnswer = value;
        }

    }
}
