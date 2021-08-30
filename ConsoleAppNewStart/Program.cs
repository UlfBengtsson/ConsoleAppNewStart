using System;

namespace ConsoleAppNewStart
{
    class Program
    {
        /*
        block comment
        many lines
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("I love to code");

            string userAgeString = AskUserFor("your age");

            Console.WriteLine("You type in " + userAgeString + " as you age.");

            int userAge = Convert.ToInt32(userAgeString);

            if (userAge >= 18)
            {
                Console.WriteLine("Welcome to the bar and have a beer");
            }
            else
            {
                Console.WriteLine("Welcome to the candy store, want a lollipop?");
            }


        }//end of Main method

//      modifire - return type - name - parameter inputs
        static string AskUserFor(string what)
        {
            Console.Write("Please enter " + what + ": ");

            string userInput = Console.ReadLine();

            return userInput;
        }

    }//end of program class
}//end of namespace
