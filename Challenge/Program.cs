using System;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            RunPaladrome();
        }

        private void RunPaladrome()
        {
            GetInput();
            CheckInput();

        }

        private void GetInput()
        {
            var input = "null";
            Console.WriteLine("Enter a word or phrase to check if it is a palidrome: ");
            input = Console.ReadLine();
            do
            {
                Console.WriteLine("A word or phrase was not entered, please enter a word or phrase: ");
                input = Console.ReadLine();
            }
    }

        private void CheckInput()
        {

        }

        private void WriteToConsole()
        {

        }
    }
}

//18006814466
//2104764533
mortgagesercicy
