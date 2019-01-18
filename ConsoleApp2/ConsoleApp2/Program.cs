using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a whole number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int temp1 = number1;
            int temp2 = number2;
            while (temp1 != temp2)
            {
                if (temp1 > temp2)
                {
                    temp1 = temp1 - temp2;
                }
                else
                {
                    temp2 = temp2 - temp1;
                }
            }
            int result = temp1;
            Console.WriteLine("{0} is GCF of {1} and {2}",result,number1,number2);
            Console.ReadLine();
        }
    }
}


