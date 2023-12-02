using System;

public class MathHelper
{
    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static double Subtract(double a, double b)
    {
        return a - b;
    }

    public static double Multiply(double a, double b)
    {
        return a * b;
    }

    public static double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        else
        {
            return a / b;
        }
    }

    public static double Power(double x, double y)
    {
        return Math.Pow(x, y);
    }

    public static double SquareRoot(double x)
    {
        if (x < 0)
        {
            throw new ArgumentException("Cannot calculate square root of negative number.");
        }
        else
        {
            return Math.Sqrt(x);
        }
    }
}
