using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CalculatorApp;

class Program
{
    private static ILogger<Program>? _logger;

    static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection().AddLogging(configure => configure.AddConsole())
                                .BuildServiceProvider();

        _logger = serviceProvider.GetService<ILogger<Program>>();

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
            _logger.LogError($"DID NOT ENTER NUMERIC VALUE. {DateTime.Now}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero.");
            _logger.LogError($"ATTEMPTED TO DIVIDE BY ZERO. {DateTime.Now}");
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("An error occurred: The specified operation is not supported.");
            _logger.LogError($"SELECTED OPERATION IS NOT DEFINED. {DateTime.Now}");
        }
        finally
        {
            Console.WriteLine("Calculation attempt finished.");
            _logger.LogInformation($"DONE. {DateTime.Now}");
        }

    }

}