using System;
using Xunit;

public class CalculatorTest
{
    [Fact]
    public void TestAddition()
    {
        double num1 = 5;
        double num2 = 3;
        string op = "+";
        double expected = 8;

        double result = PerformOperation(num1, num2, op);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestSubtraction()
    {
        double num1 = 5;
        double num2 = 3;
        string op = "-";
        double expected = 2;

        double result = PerformOperation(num1, num2, op);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestMultiplication()
    {
        double num1 = 5;
        double num2 = 3;
        string op = "*";
        double expected = 15;

        double result = PerformOperation(num1, num2, op);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestDivision()
    {
        double num1 = 6;
        double num2 = 3;
        string op = "/";
        double expected = 2;

        double result = PerformOperation(num1, num2, op);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestDivisionByZero()
    {
        double num1 = 6;
        double num2 = 0;
        string op = "/";

        Assert.Throws<DivideByZeroException>(() => PerformOperation(num1, num2, op));
    }

    private double PerformOperation(double num1, double num2, string op)
    {
        if (op == "+")
        {
            return num1 + num2;
        }
        else if (op == "-")
        {
            return num1 - num2;
        }
        else if (op == "*")
        {
            return num1 * num2;
        }
        else if (op == "/")
        {
            if (num2 != 0)
            {
                return num1 / num2;
            }
            else
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }
        }
        else
        {
            throw new InvalidOperationException("Invalid operator");
        }
    }
}