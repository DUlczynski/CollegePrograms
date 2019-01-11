using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float answer = 0;
            int column = 8;
            while (column >= 1)
                {
                Console.WriteLine("Input bit value");
                int bit = Convert.ToInt32(Console.ReadLine());
                answer = answer + (column * bit);
                column = column / 2;
            }
            Console.WriteLine("Decimal value is: {0}", answer);
            Console.ReadLine();
        }
    }
}
