using NUnit.Framework;
using System;

namespace Calc;
 
[TestFixture]
public class CalculatorTests
{
    [Test] // сложение
    public void TestAddition()
    {
        double num1 = 5;
        double num2 = 10;
        double expected = 15;

        var actual = Operation.Add(num1, num2);

        Assert.AreEqual(expected, actual);
    }
    
    [Test] // вычитание
    public void TestSubtraction()
    {
        double num1 = 10;
        double num2 = 7;
        double expected = 3;

        var actual = Operation.Subtract(num1, num2);

        Assert.AreEqual(expected, actual);
    }

    [Test] // умножение
    public void TestMultiplication()
    {
        double num1 = 5;
        double num2 = 10;
        double expected = 50;

        double actual = Operation.Multiply(num1, num2);

        Assert.AreEqual(expected, actual);
    }

    [Test] // деление
    public void TestDivision()
    {
        double num1 = 12;
        double num2 = 3;
        double expected = 4;

        double actual = Operation.Divide(num1, num2);

        Assert.AreEqual(expected, actual);
    }

    [Test] // невалидный оператор
    public void TestInvalidOperator()
    {
        double num1 = 5;
        double num2 = 10;
        string op = "@";

        Assert.Throws<InvalidOperationException>(() => Calculate(num1, num2, op));
    }

    private double Calculate(double num1, double num2, string op)
    {
        double result = 0;

        switch (op)
        {
            case "+":
                result = Operation.Add(num1, num2);
                break;
            case "-":
                result = Operation.Subtract(num1, num2);
                break;
            case "*":
                result = Operation.Multiply(num1, num2);
                break;
            case "/":
                result = Operation.Divide(num1, num2);
                break;
            default:
                throw new InvalidOperationException("Невалидный оператор");
        }

        return result;
    }

}