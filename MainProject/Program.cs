using System;
using Arithmetic;
namespace MainProject
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ArithmeticOperations arithmetic = new ArithmeticOperations();
                Console.WriteLine("Enter first number");
                arithmetic.FirstNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                arithmetic.SecondNumber = int.Parse(Console.ReadLine());
                arithmetic.Result= arithmetic.Addition(arithmetic.FirstNumber, arithmetic.SecondNumber);
                Console.WriteLine($"The sum of {arithmetic.FirstNumber} and {arithmetic.SecondNumber} = {arithmetic.Result}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

        }
    }
}
