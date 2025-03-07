using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Fraction
    {
        public int  devider;
        public int diviser;

        public Fraction(int devider, int diviser)
        {
            this.devider = devider;
            this.diviser = diviser;
        }

        public double calculate()
        {
             double res;
            res = diviser / devider;
            return res;

           
        }

        public void dis()
        {
            double resuult=calculate();
            Console.WriteLine("The result is : {0}/{1} = {2}", diviser, devider,resuult );
        }


    }
}
