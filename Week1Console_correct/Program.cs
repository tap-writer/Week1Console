using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Console_correct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int num1, num2;

            Console.WriteLine("Enter 1st Number:");
            input = Console.ReadLine();
            num1 = Convert.ToInt32(input);

            Console.WriteLine("Enter 2nd Number:");
            input = Console.ReadLine();
            num2 = Convert.ToInt32(input);

            Console.WriteLine("Sum is: {0}", Sum(num1, num2));
            Console.ReadKey();
        }

        static int Sum(int x, int y)
        {
            int sum = x;
            for (int i = 1; i < y; i++)
            {
                sum = sum * x;
            }
            return sum;
        }
    }
}
