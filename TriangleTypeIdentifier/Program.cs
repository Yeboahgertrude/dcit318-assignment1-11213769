using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Triangle Type Identifier");
            Console.WriteLine("------------------------");
            
            Console.Write("Enter the length of side 1: ");
            if (!double.TryParse(Console.ReadLine(), out double side1))
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
                return;
            }

            Console.Write("Enter the length of side 2: ");
            if (!double.TryParse(Console.ReadLine(), out double side2))
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
                return;
            }

            Console.Write("Enter the length of side 3: ");
            if (!double.TryParse(Console.ReadLine(), out double side3))
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
                return;
            }

            // Check if valid triangle
            if (!IsValidTriangle(side1, side2, side3))
            {
                Console.WriteLine("These sides do not form a valid triangle.");
                return;
            }

            string triangleType = GetTriangleType(side1, side2, side3);
            Console.WriteLine($"The triangle is a {triangleType} triangle.");
        }

        static bool IsValidTriangle(double a, double b, double c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        static string GetTriangleType(double a, double b, double c)
        {
            if (a == b && b == c)
                return "Equilateral";
            if (a == b || b == c || a == c)
                return "Isosceles";
            return "Scalene";
        }
    }
}
