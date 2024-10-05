// See https://aka.ms/new-console-template for more information
using System;

namespace GrossWageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numberOfEmployees = 3;
            string[] employeeNames = new string[numberOfEmployees];
            double[] workedHrs = new double[numberOfEmployees];
            double[] hourlyAmounts = new double[numberOfEmployees];
            double[] grossWage = new double[numberOfEmployees];

            for (int i = 0; i < numberOfEmployees; i++)
            {
                Console.Write($"Input the name of Employee {i + 1}: ");
                employeeNames[i] = Console.ReadLine();

                Console.Write($"Input the hrs worked by {employeeNames[i]}: ");
                workedHrs[i] = double.Parse(Console.ReadLine());

                Console.Write($"Input the hourly amount for {employeeNames[i]}: ");
                hourlyAmounts[i] = double.Parse(Console.ReadLine());

                grossWage[i] = CalculateGrossWage(workedHrs[i], hourlyAmounts[i]);
            }

            Console.WriteLine("\nGross Wage for Employees:");
            for (int i = 0; i < numberOfEmployees; i++)
            {
                Console.WriteLine($"{employeeNames[i]}: ${grossWage[i]:F2}");
            }
        }

        static double CalculateGrossWage(double hrs, double amount)
        {
            double gross;
            if (hrs <= 40)
            {
                gross = amount * hrs;
            }
            else
            {
                gross = (amount * 40) + ((hrs - 40) * amount * 1.5);
            }
            return gross;
        }
    }
}

