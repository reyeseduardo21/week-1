using System;

namespace FizzBuzz
{
    class Program
    {
        private static int upper;
        private static int lower;

        private static Boolean number = false;

        private static int div1;

        private static int div2;
        static void Main(string[] args)
        {
            // allow user to give us upper bound and lower bound (think validate)
            // allow the user to set the condition for multiple
            // count from 0 to 100 and print each number per line
            // if number is multiple of 3, print fizz
            // if number is multiple of 5, print buzz
            // if number is multiple of both, print fizzbuzz
            RunFizzBuzz();

        }

        private static void RunFizzBuzz()
        {
            GetBounds();
            GetConditions();

            for (int i = lower; i <= upper; i += 1)
            {
                Print(i);
            }


        }

        private static void Print(int x)
        {

            if (x == 0)
                WriteToConsole(x);
            else if (x % (div1 * div2) == 0)
                WriteToConsole("fizzbuzz");
            else if (x % div1 == 0)
                WriteToConsole("fizz");
            else if (x % div2 == 0)
                WriteToConsole("buzz");

            else
                WriteToConsole(x);
        }

        private static void GetBounds()
        {
            var input = "null";
            do
            {
                Console.WriteLine("Enter starting number to begin counting:");
                input = Console.ReadLine();
                try
                {
                    lower = Convert.ToInt32(input);
                    number = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid entry. Enter an integer. ", e);
                }
            } while (number == false);

            number = false;

            do
            {
                Console.WriteLine("Enter ending number:");
                input = Console.ReadLine();
                try
                {
                    upper = Convert.ToInt32(input);
                    number = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid entry. Enter an integer. ", e);
                }
            } while (number == false);




        }

        private static void GetConditions()
        {
            var input = "null";
            do
            {
                Console.WriteLine("Enter a number you would like to find multiples of to type fizz instead:");
                input = Console.ReadLine();
                try
                {
                    div1 = Convert.ToInt32(input);
                    number = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid entry. Enter an integer. ", e);
                }
            } while (number == false);

            number = false;

            do
            {
                Console.WriteLine("Enter another number you would like to find multiples of to type buzz instead:");
                input = Console.ReadLine();
                try
                {
                    div2 = Convert.ToInt32(input);
                    number = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid entry. Enter an integer. ", e);
                }
            } while (number == false);
        }

        private static void WriteToConsole(string p)
        {
            Console.WriteLine(p);
        }

        private static void WriteToConsole(int p)
        {
            Console.WriteLine(p);
        }


    }
}

