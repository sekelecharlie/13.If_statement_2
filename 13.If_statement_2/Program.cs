using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.If_statement_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number 1 ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2 ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetMax(num1, num2));
            Console.ReadLine(); 
        }
        static int GetMax(int num1, int num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine("The max is ");
                return num1;
            }
            else
            {
                Console.WriteLine("The max is ");
                return num2;
            }
        }
    }
}
