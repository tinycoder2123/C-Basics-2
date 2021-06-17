using System;

namespace Module1Assignment2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 0 and 255: ");
            int number1;
            int number2;
            int result;

            if (!int.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine("FormatException: Input string was not in a correct format.");
            }
            Console.Write("Enter another number between 0 and 255: ");
            if (!int.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine("FormatException: Input string was not in a correct format.");
            }
            result = number1 / number2;
            Console.WriteLine("{0} divided by {1} is {2}", number1, number2, result);
        }
    }
}