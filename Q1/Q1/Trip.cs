using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Trip
    {
        public string destnation;
        public double distraveled;
        public double costofgas;
        public int numberofgallon;
        double cost1;
        double cost2;

        public Trip()
        {
            destnation = "Mureee";
            distraveled = 20.5;
            costofgas = 4321;
            numberofgallon = 56;

        }

        public void cost()
        {
            cost1 = numberofgallon / distraveled;
            cost2 = costofgas / numberofgallon;

        }

        public void display()
        {
            Console.WriteLine("The detination is : {0}", destnation);
            Console.WriteLine("Total distance traveled is : {0} ", distraveled);
            Console.WriteLine("Total cost of gas :{0}", costofgas);
            Console.WriteLine("Total number of gallons are :{0}", numberofgallon);
            cost();
            Console.WriteLine("The miles aper galon are : {0}", cost1);
            Console.WriteLine("The cost of galon per ile is : {0}", cost2);
        }


    }
}
