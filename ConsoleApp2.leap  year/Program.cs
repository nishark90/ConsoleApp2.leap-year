using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.leap__year
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year");   
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine("Leap year");
            }
            else
            {
                Console.WriteLine("Not Leap year");
            }
                Console.ReadKey();   
        }
    }
}
