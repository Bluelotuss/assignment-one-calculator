using System;

namespace assignment_one_calculator
{
    class Program
    {
       
        static void runDivision()
        {
            int num1 = 0;
            int num2 = 0;
            
            while(num1 == 0 || num2 == 0)
            {
            Console.WriteLine("Type a number, and then press Enter");
            num1 = int.Parse(Console.ReadLine() ?? "");

            Console.WriteLine("Type another number, and then press Enter");
            num2 = int.Parse(Console.ReadLine() ?? "");

                if(num1 == 0 || num2 == 0)
                {
                    Console.WriteLine("0 is not a valid number in this case");
                }
            }
            Console.WriteLine($"The result: {num1} / {num2} = " + (num1 / num2));

        }

        static void runMultiplication()
        {
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Type a number, and then press Enter");
            num1 = int.Parse(Console.ReadLine() ?? "");

            Console.WriteLine("Type another number, and then press Enter");
            num2 = int.Parse(Console.ReadLine() ?? "");

            Console.WriteLine($"The result: {num1} * {num2} = " + (num1 * num2));
        }

        static void runAddition()
        {
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Type a number, and then press Enter");
            num1 = int.Parse(Console.ReadLine() ?? "");

            Console.WriteLine("Type another number, and then press Enter");
            num2 = int.Parse(Console.ReadLine() ?? "");

            Console.WriteLine($"The result: {num1} + {num2} = " + (num1 + num2));
        }

        static void runSubtraction()
        {
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Type a number, and then press Enter");
            num1 = int.Parse(Console.ReadLine() ?? "");

            Console.WriteLine("Type another number, and then press Enter");
            num2 = int.Parse(Console.ReadLine() ?? "");

            Console.WriteLine($"The result: {num1} - {num2} = " + (num1 - num2));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the console calculator");

        var keepAlive = true;
        while(keepAlive)
        {
            try
            {
                Console.WriteLine("Please enter a letter from the list corresponding to the mathematical operation which you would like to perform");
                Console.WriteLine("d - division\nm - multiplication\na - addition\ns - subtraction\ne - exit calculator");
                Console.Write("Your option? ");
                var calculationChoice = (Console.ReadLine() ?? "");
                switch (calculationChoice)
            {
                case "d":
                    runDivision();
                    break;
                case "m":
                    runMultiplication();
                    break;
                case "a":
                    runAddition();
                    break;
                case "s":
                    runSubtraction();
                    break;
                case "e":
                    keepAlive = false;
                    break;
                default:
                    Console.WriteLine("That is not a valid entry letter!");
                    break;
            }
            Console.WriteLine("Hit any key to continue!");
            Console.ReadKey();
            Console.Clear();
            }
            catch
            {
                Console.WriteLine("That is not a valid assignment number!");
                Console.ResetColor();
            }
        }
        }
    }
}
