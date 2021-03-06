// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;

namespace AssignmentDotNet
{

  
    internal class Program
    {
        
        static void Main(string[] arg)
        {
            try
            {
                Console.Write("Enter the principal amount :");
                double p = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the rate of interest from financer :");
                double i = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the loan duration :");
                double t = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the months :");
                double n = Convert.ToDouble(Console.ReadLine());

                var test = new EmiCalculator();

                double emi = test.CalculateEmi(p, i, t, n);

                Console.WriteLine("Monthly Emi : " + Math.Round(emi, 2) + " INR");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter valid integer");
            }

            finally
            {
                Console.WriteLine("Please enter the valid inputs");
               
            }
           

        }


    }

}
