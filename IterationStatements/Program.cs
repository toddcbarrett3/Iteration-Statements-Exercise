namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        
        //Write a method to check whether a given number is even or odd
        
        //Write a method to check whether a given number is positive or negative
        
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //LukeWarm Section:

            Methods.LargeNumbers();

            Methods.NumbersByThree();

            Console.WriteLine("Let\'s check to see if two numbers are equal \nEnter the first number:");
            var num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            var num2 = int.Parse(Console.ReadLine());
            Methods.EqualOrNot(num1, num2);

            Console.WriteLine("Enter a number:");
            var num3 = int.Parse(Console.ReadLine());
            Methods.OddOrEven(num3);

            Console.WriteLine("Enter a number:");
            var num4 = int.Parse(Console.ReadLine());
            Methods.PositiveOrNegative(num4);

            Console.WriteLine("We need to determine if you are eligble to vote, how old are you?");
            var votingAge = int.Parse(Console.ReadLine());
            Methods.OldEnoughToVote(votingAge);


            //Heatin Up Section:

            Console.WriteLine("Enter a number:");
            var range = int.Parse(Console.ReadLine());
            Methods.WithinRange(range);

            Console.WriteLine("Enter a number to display the numbers multiplication table:");
            var multi = int.Parse(Console.ReadLine());
            Methods.MultiTable(multi);
        }
    }
}
