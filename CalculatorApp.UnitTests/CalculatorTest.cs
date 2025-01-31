using NUnit.Framework;
using CalculatorApp;

namespace CalculatorApp.UnitTests;

[TestFixture]
public class CalculatorTest
{
    private readonly Calculator _calculator;
  
    public CalculatorTest()
    {
        _calculator = new Calculator();

    }
    [Test]
    public void Add_ShouldReturnSum()
    {
        double num1 = 2;
        double num2 = 2;
        string operation = "add";

        double result = _calculator.PerformOperation(num1, num2, operation);
        NUnit.Framework.Assert.That(result, Is.EqualTo(4));
    }
    [Test]
    public void Subtract_ShouldReturnDiff()
    {
        double num1 = 6;
        double num2 = 9;
        string operation = "subtract";

        double result = _calculator.PerformOperation(num1, num2, operation);
        NUnit.Framework.Assert.That(result, Is.EqualTo(3));
    }
    [Test]
    public void Multiply_ShouldReturnProduct()
    {
        double num1 = 2;
        double num2 = 4;
        string operation = "multiply";

        double result = _calculator.PerformOperation(num1, num2, operation);
        NUnit.Framework.Assert.That(result, Is.EqualTo(8));
    }
    [Test]
    public void Divide_ShouldReturnQuotient()
    {
        double num1 = 10;
        double num2 = 5;
        string operation = "divide";

        double result = _calculator.PerformOperation(num1, num2, operation);
        NUnit.Framework.Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void ThrowDivisibleByZero()
    {
        double num1 = 6;
        double num2 = 0;
        string operation = "divide";

        Assert.Throws<DivideByZeroException>(() => _calculator.PerformOperation(num1, num2, operation));
    }

    [Test]
    public void ThrowInvalidOperation()
    {
        double num1 = 6;
        double num2 = 0;
        string operation = "exp";

        Assert.Throws<InvalidOperationException>(() => _calculator.PerformOperation(num1, num2, operation));
    }
    [Test]
    public void ThrowFormatException()
    {
        string num1 = "six";
        string num2 = "seven";
        string operation = "add";

        Assert.Throws<FormatException>(() => { 
            double parseNum1 = double.Parse(num1);
            double parseNum2 = double.Parse(num2);
            _calculator.PerformOperation(parseNum1, parseNum2, operation);
            });
    }

}