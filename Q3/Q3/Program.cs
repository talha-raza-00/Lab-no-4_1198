using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.input();
            book1.dis();
            Console.Write("\nEnter the title of boook to search . ");
            string tit=Console.ReadLine();
            book1.search(tit);
        }
    }
}
