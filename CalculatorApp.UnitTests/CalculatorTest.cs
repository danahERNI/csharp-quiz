using NUnit.Framework;
using Xunit;
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

}