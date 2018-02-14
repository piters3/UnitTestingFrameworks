﻿using System;

namespace Calculator
{
    public class Calc
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Nie można dzielić przez zero!!!");
            }
            else
            {
                return a / b;
            }
        }
    }
}
