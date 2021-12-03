// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;

namespace AssignmentDotNet
{

    internal class Calc
    {

                public  double CalculateEmi(double p,double i,double t,double n)
             {

                  double emi;
                  emi=p * Math.Pow((1 + i / n),
                                                 (n * t));
                  return emi/24;



                 }
    }
    internal class Program
    {
        
        static void Main(string[] arg)
        {
            
            Console.Write("Enter the principal amount :");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the rate of interest from financer :");
            double i = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the loan duration :");
            double t = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the months :");
            double n = Convert.ToDouble(Console.ReadLine());


            var test = new Calc();

            double emi = test.CalculateEmi(p,i,t,n);

            Console.WriteLine("Monthly Emi : " +Math.Round(emi,2) + " INR");

        }


    }

}