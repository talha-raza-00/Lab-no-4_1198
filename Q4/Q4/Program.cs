using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MealCard mealCard1 = new MealCard();
            mealCard1.input();
            mealCard1.DisplayBalance();

            mealCard1.newpoints();
            mealCard1.DisplayBalance();

            mealCard1.PurchaseFood();
            mealCard1.DisplayBalance();
        }
    }
}
