using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Grade Calculator");
            Console.WriteLine("----------------");
            
            int grade = -1;
            while (true)
            {
                Console.Write("Enter your numerical grade (0-100): ");
                if (int.TryParse(Console.ReadLine(), out grade))
                {
                    if (grade >= 0 && grade <= 100)
                    {
                        break;
                    }
                    Console.WriteLine("Invalid grade! Please enter a number between 0 and 100.");
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                }
            }

            string letterGrade = GetLetterGrade(grade);
            Console.WriteLine($"Your letter grade is: {letterGrade}");
        }

        static string GetLetterGrade(int grade)
        {
            if (grade >= 90) return "A";
            if (grade >= 80) return "B";
            if (grade >= 70) return "C";
            if (grade >= 60) return "D";
            return "F";
        }
    }
}
