namespace CalculatorApp;

public class Calculator
{
    public double PerformOperation(double num1, double num2, string operation)
    {
        switch (operation)
        {
            case "add":
                return num1 + num2;
            case "subtract":
                if(num1 < num2)
                {
                    var temp = num1;
                    return num2 - temp;
                }
                else
                {
                    return num1 - num2;
                }
            case "multiply":
                return num1 * num2;
            case "divide":
                if (num2 == 0)
                    throw new DivideByZeroException();
                else
                {
                    return num1 / num2;
                }
                
            default:
                throw new InvalidOperationException();
        }
    }
}