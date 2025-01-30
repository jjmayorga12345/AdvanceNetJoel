using System;
using System.Collections.Generic;
using System.Linq;

namespace Mathmatics.ConsoleApp

{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string operation;
                double operand1, operand2;
                ValidateArguments(args, out operation, out operand1, out operand2);

                AdvMath advMath = new AdvMath();
                double result;
                string operationDesc;

                switch (operation)
                {
                    case "area":
                        result = advMath.CalculateArea(operand1, operand2);
                        operationDesc = "area";
                        break;

                    case "average":
                        result = advMath.CalculateAverage(new List<double> { operand1, operand2 });
                        operationDesc = "average";
                        break;

                    case "squared":
                        result = advMath.CalculateSquared(operand1);
                        operationDesc = "squared";
                        break;

                    case "hypotenuse":
                        result = advMath.CalculateHypotenuse(operand1, operand2);
                        operationDesc = "hypotenuse";
                        break;

                    default:
                        throw new ArgumentException("Invalid operation. Use: area, average, squared, hypotenuse.");
                }

                Console.WriteLine($"The {operationDesc} is: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static void ValidateArguments(string[] args, out string operation, out double operand1, out double operand2)
        {
            if (args.Length < 2)
                throw new ArgumentException("Not enough arguments. Usage: <operation> <num1> [num2]");

            operation = args[0].ToLower();
            if (!double.TryParse(args[1], out operand1))
                throw new ArgumentException("First number is invalid.");

            operand2 = 0;
            if (operation != "squared")
            {
                if (args.Length < 3 || !double.TryParse(args[2], out operand2))
                    throw new ArgumentException("Second number is invalid.");
            }
        }
    }
}
