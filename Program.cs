using System;

namespace assignment_one_calculator
{
    class Program
    {
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
                            RunDivision(PickNumber(), PickNumber());
                            break;
                        case "m":
                            RunMultiplication(PickNumber(), PickNumber());
                            break;
                        case "a":
                            RunAddition(PickNumber(), PickNumber());
                            break;
                        case "s":
                            RunSubtraction(PickNumber(), PickNumber());
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
                        Console.WriteLine("That is not a valid letter!");
                    }
                }
        }

        static int PickNumber()
        {
            int num = 0;
            Console.WriteLine("Type a number, and then press Enter");
            return num = int.Parse(Console.ReadLine() ?? "");
        }

        public static void RunDivision(int num1, int num2)
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

        public static void RunMultiplication(int num1, int num2)
        {
            Console.WriteLine($"The result: {num1} * {num2} = " + (num1 * num2));
        }

        static void RunAddition(int num1, int num2)
        {
            Console.WriteLine($"The result: {num1} + {num2} = " + (num1 + num2));
        }

        static void RunSubtraction(int num1, int num2)
        {
            Console.WriteLine($"The result: {num1} - {num2} = " + (num1 - num2));
        }

        public static int Multiplication(int x, int y)
        {
            return x * y;
        }
    }
}
