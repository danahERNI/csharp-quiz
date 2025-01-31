namespace CalculatorApp;

class Program
{
    static void Main(string[] args)
    {
        double num1 = 0;
        double num2 = 0;
        var calculator = new Calculator(); 
        try
        {
            Console.WriteLine("Enter the first number:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the operation (add, subtract, multiply, divide):");
            string operation = Console.ReadLine()?.ToLower() ?? string.Empty;

   
            double result = calculator.PerformOperation(num1, num2, operation);
            Console.WriteLine($"The result is: {result}");
        }
        catch   (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter numeric values.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("An error occurred: The specified operation is not supported.");
        }
        finally
        {
            Console.WriteLine("Calculation attempt finished.");
        }

    }

}