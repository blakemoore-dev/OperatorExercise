using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1:
            int a = 17, b = 4, quotient = a/b, remainder = a%b;
            Console.WriteLine($"Variable a = 17 and b = 4\n" +
                              $"Addition: a + b = {a+b}\n" +
                              $"Subtraction: a - b = {a-b}\n" +
                              $"Multiplications: a * b = {a*b}\n" +
                              $"Division (quotient): a / b = {quotient}\n" +
                              $"Modulus (remainder): a % b = {remainder}");

            Console.WriteLine();

            // Exercise 2:
            static double AreaOfCircle(double r)
            {
                var pi = Math.PI;
                double result = pi * (r * r);
                Console.WriteLine($"The area of a circle with a radius of {r} is {result}");
                return result;
            }

            Console.Write("What is the radius of your circle?    ");
            var radius = double.Parse(Console.ReadLine());
            AreaOfCircle(radius);
        }
    }
}
