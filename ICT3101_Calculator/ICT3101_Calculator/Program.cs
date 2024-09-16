﻿// Program.cs
using ICT3101_Calculator;

class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;
        Calculator _calculator = new Calculator();
        // Display title as the C# console calculator app.
        Console.WriteLine("Console Calculator in C#\r");
        Console.WriteLine("------------------------\n");
        while (!endApp)
        {
            // Declare variables and set to empty.
            string numInput1 = "";
            string numInput2 = "";
            string numInput3 = ""; // Additional input for certain calculations
            double result = 0;

            // Ask the user to choose an operator.
            Console.WriteLine("Choose an operator from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.WriteLine("\tf - Factorial");
            Console.WriteLine("\tt - Triangle Area");
            Console.WriteLine("\tc - Circle Area");
            Console.WriteLine("\tmtbf - MTBF");
            Console.WriteLine("\tavail - Availability");
            Console.WriteLine("\tcfi - Current Failure Intensity");
            Console.WriteLine("\tanef - Average Number of Expected Failures");
            Console.Write("Your option? ");
            string op = Console.ReadLine();

            // Ask for the first number.
            Console.Write("Type the first number, and then press Enter: ");
            numInput1 = Console.ReadLine();
            double cleanNum1 = 0;
            while (!double.TryParse(numInput1, out cleanNum1))
            {
                Console.Write("This is not valid input. Please enter a numeric value: ");
                numInput1 = Console.ReadLine();
            }

            // Ask for the second number.
            Console.Write("Type the second number, and then press Enter: ");
            numInput2 = Console.ReadLine();
            double cleanNum2 = 0;
            while (!double.TryParse(numInput2, out cleanNum2))
            {
                Console.Write("This is not valid input. Please enter a numeric value: ");
                numInput2 = Console.ReadLine();
            }

            double cleanNum3 = 0; // Initialize additional input

            // Check if additional input is needed
            if (op == "cfi" || op == "anef")
            {
                // Ask for the third number.
                Console.Write("Type the third number, and then press Enter: ");
                numInput3 = Console.ReadLine();
                while (!double.TryParse(numInput3, out cleanNum3))
                {
                    Console.Write("This is not valid input. Please enter a numeric value: ");
                    numInput3 = Console.ReadLine();
                }
            }

            try
            {
                result = _calculator.DoOperation(cleanNum1, cleanNum2, op, cleanNum3);
                if (double.IsNaN(result))
                {
                    Console.WriteLine("This operation will result in a mathematical error.\n");
                }
                else
                {
                    Console.WriteLine("Your result: {0:0.#####}\n", result);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
            }

            Console.WriteLine("------------------------\n");
            // Wait for the user to respond before closing.
            Console.Write("Press 'q' and Enter to quit the app, or press any other key and Enter to continue: ");
            if (Console.ReadLine() == "q") endApp = true;
            Console.WriteLine("\n"); // Friendly linespacing.
        }
        return;
    }
}
