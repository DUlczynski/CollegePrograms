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
            Console.WriteLine("AS2012 Task");
            Console.ReadLine();
            int answer = 0;
            int column = 8;
            while (column >= 1)
                {
                Console.Write("Input a bit value:");
                int bit = Convert.ToInt32(Console.ReadLine());
                answer = answer + (column * bit);
                column = column / 2;
            }
            Console.WriteLine("Decimal value is: {0}", answer);
            Console.ReadLine();


            Console.WriteLine("\nAS2013 Task");
            Console.ReadLine();
            Console.WriteLine("Player One  enter your chosen number");
            int NumberToGuess = Convert.ToInt32(Console.ReadLine());
            while (NumberToGuess < 1 || NumberToGuess >10)
            {
                Console.WriteLine("Invalid Number");
                Console.WriteLine("Player One  enter your chosen number");
                NumberToGuess = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();
            int Guesses = 0;
            int NumberOfGuesses = 0;
            while (Guesses != NumberToGuess && NumberOfGuesses<5)
            {
                Console.WriteLine("Player Two enter your guess");
                Guesses = Convert.ToInt32(Console.ReadLine());
                NumberOfGuesses++;
            }
            if (Guesses == NumberToGuess)
            {
                Console.WriteLine("Player Two wins!");
            }
            else
            {
                Console.WriteLine("Player One Wins!");
            }
            Console.ReadLine();

            Console.WriteLine("\nAS2013 Task");
            Console.ReadLine();
            int[] ISBN = new int[13];
            for (int count = 0; count < 13; count++)
            {
                Console.WriteLine("Please enter your next value for the ISBN:");
                ISBN[count] = Convert.ToInt32(Console.ReadLine());
            }
            int CalculatedDigit = 0;
           int Count = 0;
                while (Count < 12)
            {
                CalculatedDigit = CalculatedDigit + ISBN[Count];
                Count++;
                CalculatedDigit = CalculatedDigit + ISBN[Count] * 3;
                Count++;
            }
            Console.WriteLine(CalculatedDigit);
            Console.ReadLine();
            while (CalculatedDigit >= 10)

            {
                CalculatedDigit = CalculatedDigit - 10;
            }
            Console.WriteLine(CalculatedDigit);
            Console.ReadLine();
            CalculatedDigit = CalculatedDigit - 10;
            if (CalculatedDigit == 10)
            {
                CalculatedDigit = 0;
            }
            Console.WriteLine(CalculatedDigit);
            Console.ReadLine();
            if (CalculatedDigit == ISBN[12])
            {
                Console.WriteLine("Valid Input");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            Console.ReadLine();
        }
    }
}
