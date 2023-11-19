using System;
namespace Calc;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Amazing calculator");

        while (true)
        {
            Console.WriteLine("First number, bro:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter operator (+, -, *, /):");
            string op = Console.ReadLine();

            Console.WriteLine("Second number, bro:");
            double num2 = double.Parse(Console.ReadLine());

            double result = 0;

            switch (op)
            {
                case "+":
                    result = Operation.Add(num1,num2);
                    break;
                case "-":
                    result = Operation.Subtract(num1,num2);
                    break;
                case "*":
                    result = Operation.Multiply(num1, num2);
                    break;
                case "/":
                    result = Operation.Divide(num1, num2);
                    break;
                default:
                    Console.WriteLine("Think again, bro");
                    continue;
            }

            Console.WriteLine("Result: " + result);

            Console.WriteLine("Are you going to count anything else, dude? (y/n)");
            string choice = Console.ReadLine();

            if (choice.ToLower() != "y")
                break;
        }
    }
}