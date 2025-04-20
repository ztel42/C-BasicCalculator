
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        string input1 = Console.ReadLine();
        double num1;
        if (!double.TryParse(input1, out num1))
        {
            Console.WriteLine("Invalid input for first number.");
            return;
        }

        Console.WriteLine("Enter the second number:");
        string input2 = Console.ReadLine();
        double num2;
        if (!double.TryParse(input2, out num2))
        {
            Console.WriteLine("Invalid input for second number.");
            return;
        }

        Console.WriteLine("Enter the operation (+, -, *, /):");
        string operation = Console.ReadLine().Trim();

        double result;
        switch (operation)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                    return;
                }
                result = num1 / num2;
                break;
            default:
                Console.WriteLine("Invalid operation.");
                return;
        }

        Console.WriteLine($"The result is: {result}");
    }
}