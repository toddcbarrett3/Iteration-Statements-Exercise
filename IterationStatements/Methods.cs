using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationStatements
{
    internal class Methods
    {
        //LukeWarm Section:

        public static void LargeNumbers()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        public static void NumbersByThree()
        {
            for (int i = 3; i <= 999; i+=3)
            {
                Console.WriteLine(i);
            }
        }
        public static void EqualOrNot(int num1, int num2)
        {
            if(num1 == num2)
            {
                Console.WriteLine($"{num1} and {num2} are Equal");
            }
            else
            {
                Console.WriteLine($"{num1} and {num2} are Not Equal");
            }
        }
        public static void OddOrEven(int num3)
        {
            if (num3%2 == 0)
            {
                Console.WriteLine($"{num3} is an Even Number");
            }
            else
            {
                Console.WriteLine($"{num3} is an Odd Number");
            }
        }
        public static void PositiveOrNegative(int num4)
        {
            if (num4 > 0)
            {
                Console.WriteLine($"{num4} is a Positive Number");
            }
            else
            {
                Console.WriteLine($"{num4} is a Negative Number");
            }
        }
        public static void OldEnoughToVote(int votingAge)
        {
            if (votingAge >= 18)
            {
                Console.WriteLine($"Congratulations... You are old enough to vote!");
            }
            else
            {
                var diff = 18 - votingAge;
                Console.WriteLine($"Unfortunately you have to wait {diff} more years until you are eligble to vote :(");
            }
        }

        //Heatin Up Section:

        public static void WithinRange(int range)
        {
            if (range >= -10 && range <= 10)
            {
                Console.WriteLine($"{range} is within the specified range");
            }
            else
            {
                Console.WriteLine($"{range} is outside the specified range");
            }
        }
        public static void MultiTable(int multi)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} X {multi} = {i * multi}");
            }
        }
    }
}
