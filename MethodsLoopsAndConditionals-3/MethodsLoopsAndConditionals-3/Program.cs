namespace MethodsLoopsAndConditionals_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintThousand();

            PrintNumbers999();

            IsEqualOrNot(2, 4);

            EvenOrOdd(4);

            IsPositiveOrNeg(-5);

            VotingAgeOrNot();


        }
        //Write a method that will print to the console all numbers 1000 through -1000//
        public static void PrintThousand()
        {
            for (int i =1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        //Print numbers 3 to 999 by 3 each time//
        public static void PrintNumbers999()
        {
            for (int i=3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }


        public static void IsEqualOrNot(int x, int y)
        {
            if (x == y)
            {
                Console.WriteLine("these two numbers are equal");
            }
            else
            {
                Console.WriteLine("these two numbers are not equal");
            }
        }
        public static void EvenOrOdd(int x)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine("this is an even number");
            }
            else
            {
                Console.WriteLine("this is an odd number");
            }
        }
        public static void IsPositiveOrNeg(int x)
        {
            if (x > 0)
            {
                Console.WriteLine("This number is positive");
            }
            else if (x == 0)
            {
                Console.WriteLine("this number is 0");
            }
            else
            {
                Console.WriteLine("this number is negative");
            }
        }

        public static void VotingAgeOrNot()
        {
            Console.Write("Please enter your age: ");
            var age = Convert.ToInt32(Console.ReadLine);

            if (age >= 18)
            {
                Console.WriteLine("you are old enough to vote.");
            }
            else
            {
                Console.WriteLine("you are not old enough to vote");

            }
        }
    }
}