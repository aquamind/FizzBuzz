using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(FizzBuzz.GetFizzBuzz(i));
            }
            Console.ReadLine();
        }
    }

    public class FizzBuzz
    {
        public static string GetFizzBuzz(int num)
        {
            bool isFizz = num % 3 == 0;
            bool isBuzz = num % 5 == 0;

            if (isFizz && isBuzz)
            {
                return "FizzBuzz";
            }
            else if (isFizz)
            {
                return "Fizz";
            }
            else if (isBuzz)
            {
                return "Buzz";
            }
            else
            {
                return num.ToString();
            }
        }
    }
}
