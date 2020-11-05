using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Numcalc
{
    class Model
    {




        //Returns the addition
        private double Addition(double num1, double num2)
        {
            var result = num1 + num2;
            return result;
        }



        //Returns the multiplication
        private double Multiplication(double num1, double num2)
        {
            var result = num1 * num2;
            return result;
        }



        //Returns the exponentiation
        private double Exponentiation(double baseNum, double power)
        {
            return Math.Pow(baseNum, power);
        }



        //Returns the value of sine
        private double Sine(double angle)
        {
            return Math.Sin(angle);
        }



        //Returns the value of cosine
        private double Cosine(double angle)
        {
            return Math.Cos(angle);
        }



        //Returns the value of tangent
        private double Tangent(double angle)
        {
            return Math.Tan(angle);
        } 
    }
}
