using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyndromSolve
{
    class Program
    {
        //Hello!
        //Try to enter 196, 295, 394, 493, 592, 691, 790 
        //And see the result of polyndrom and iteration of it!
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter your number for defining is it polyndrom:");
                var input = Console.ReadLine();
                var polyndrom = GetPolyndrom(long.Parse(input));
                Console.WriteLine($"Polyndrom in {polyndrom}");
            }
        }

        public static long RevLong(long l)
        {
            long tmp = l;
            long r = 0L;

            if (tmp < 0)
                tmp *= -1;

            while (tmp > 0)
            {
                r = (r * 10) + (tmp - ((tmp / 10)) * 10);
                tmp = tmp / 10;
            }

            return r * (l < 0 ? -1 : 1);
        }

        public static long GetPolyndrom(long number)
        {
            long result = number;

            for (int i = 0; i < 1000000000; i++)
            {
                result = result + RevLong(result);
                if (result == RevLong(result))
                {
                    Console.WriteLine($"Iteration in on {i} num;");
                    return result;
                }
            }

            return result;
        }
    }
}
