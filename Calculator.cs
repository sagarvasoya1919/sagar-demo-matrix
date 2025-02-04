// This is a basic calculator application that performs addition, subtraction, multiplication, and division based on user input.

using System;
using System.Collections.Generic;

public class Calculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number: ");
        double num1;
        while (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Invalid input. Please enter a valid number:");
        }

        Console.WriteLine("Enter the operator (+, -, *, /): ");
        string op = Console.ReadLine();
        Console.WriteLine("Enter the operator (+, -, *, /): ");
        string op = Console.ReadLine();

        Console.WriteLine("Enter the second number: ");
        while (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Invalid input. Please enter a valid number:");
        }

        if (op == "+")
        {
            Console.WriteLine(num1 + num2);
        }
        else if (op == "-")
        {
            Console.WriteLine(num1 - num2);
        }
        else if (op == "*")
        {
            Console.WriteLine(num1 * num2);
        }
        else if (op == "/")
        {
            if (num2 != 0)
            {
                Console.WriteLine(num1 / num2);
            }
            else
            {
                Console.WriteLine("Error: Cannot divide by zero");
            }
        }
        else
        {
            Console.WriteLine("Error: Invalid operator");
        }
    }
}
