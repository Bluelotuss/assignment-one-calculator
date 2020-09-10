using System;

namespace assignment_one_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Welcome to the console calculator");

            Console.WriteLine("Type a number, and then press Enter");
            num1 = int.Parse(Console.ReadLine() ?? "");

            Console.WriteLine("Type another number, and then press Enter");
            num2 = int.Parse(Console.ReadLine() ?? "");

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
                            runDivision(num1, num2);
                            break;
                        case "m":
                            runMultiplication(num1, num2);
                            break;
                        case "a":
                            runAddition(num1, num2);
                            break;
                        case "s":
                            runSubtraction(num1, num2);
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
                    }
                }
        }
       
        static void runDivision(int num1, int num2)
        {   
            while(num1 == 0 || num2 == 0)
            {
            Console.WriteLine("0 is not a valid number in this case");
            Console.WriteLine("Type a number, and then press Enter");
            num1 = int.Parse(Console.ReadLine() ?? "");

            Console.WriteLine("Type another number, and then press Enter");
            num2 = int.Parse(Console.ReadLine() ?? "");
            }

            Console.WriteLine($"The result: {num1} / {num2} = " + (num1 / num2));
        }

        static void runMultiplication(int num1, int num2)
        {
            Console.WriteLine($"The result: {num1} * {num2} = " + (num1 * num2));
        }

        static void runAddition(int num1, int num2)
        {
            Console.WriteLine($"The result: {num1} + {num2} = " + (num1 + num2));
        }

        static void runSubtraction(int num1, int num2)
        {
            Console.WriteLine($"The result: {num1} - {num2} = " + (num1 - num2));
        }
    }
}
