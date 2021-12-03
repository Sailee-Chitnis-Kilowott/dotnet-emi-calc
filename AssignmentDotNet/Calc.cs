using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
