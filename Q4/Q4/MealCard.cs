using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class MealCard
    {
        public string studentname;
        public int balance;

        public void input()
        {
            Console.Write("Entter your name : ");
            studentname = Console.ReadLine();
            Console.Write("Enter the balance of student : ");
            balance=int.Parse(Console.ReadLine());

        }

        public void newpoints()
        {
            int newbal;
            Console.Write("\nEnter the new ammount of balance : ");
            newbal = int.Parse(Console.ReadLine());
            balance=balance+newbal;

        }

        public void PurchaseFood()
        {
            int points;
            Console.Write("\nEnter the amount of points to buy foood : ");
            points = int.Parse(Console.ReadLine());
            if (points <= 0)
            {
                Console.WriteLine("Invalid amount. Points to deduct must be positive.");
                return;
            }

            if (balance >= points)
            {
                balance -= points;
                Console.WriteLine($"Food purchased for {points} points. Remaining balance: {balance}");
            }
            else
            {
                Console.WriteLine("Insufficient balance. Purchase not allowed.");
            }
        }

        public void DisplayBalance()
        {
            Console.WriteLine($"{studentname}'s Meal Card Balance: {balance} points");
        }

    }
}
