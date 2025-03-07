using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Book
    {
        public string[] isbn = new string[20];
        public string[] title = new string[20];
        public string[] majorarea = new string[20];
        public string[] subarea = new string[20];
        public int[] nopage = new int[20];
        public int[] price = new int[20];

        public void input()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.Write($"\nEnter the ISBN of {i + 1} number book : ");
                isbn[i]= Console.ReadLine();
                Console.Write($"Enter the Title of {i + 1} number book : ");
                title[i] = Console.ReadLine();
                Console.Write($"Enter the Major Area of {i + 1} number book : ");
                majorarea[i] = Console.ReadLine();
                Console.Write($"Enter the Sub area of {i + 1} number book : ");
                subarea[i] = Console.ReadLine();
                Console.Write($"Enter the price of {i+1} number book : ");
                price[i]=int.Parse( Console.ReadLine() );
                Console.Write($"Enter the Number of pages of {i + 1} number book : ");
                nopage[i] = int.Parse(Console.ReadLine());

            }

        }

        public void dis()
        {
            Console.WriteLine("\n\tRECORD OF BOOKS");
            for (int i = 0;i < 2;i++)
            {
                Console.WriteLine("\n   Book NUMBER {0}",i+1);
                Console.WriteLine($"Title = {title[i]} ");
                Console.WriteLine($"Main area = {majorarea[i]} ");
                Console.WriteLine($"Sub area = {subarea[i]} ");
                Console.WriteLine($"Price = {price[i]} ");
                Console.WriteLine($"no pf pages  = {nopage[i]} ");

            }
        
        
        }

        public void search(string title1)
        {
            for(int i = 0;i<2 ; i++)
            {
                if(title1 == title[i])
                {
                    Console.WriteLine($"Title = {title[i]} ");
                    Console.WriteLine($"Main area = {majorarea[i]} ");
                    Console.WriteLine($"Sub area = {subarea[i]} ");
                    Console.WriteLine($"Price = {price[i]} ");
                    Console.WriteLine($"no pf pages  = {nopage[i]} ");
                }
               
            }
        }


    }
}
