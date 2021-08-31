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
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("I love to code");

            bool keepLooping = true;

            while (keepLooping)
            {
                Console.Clear();
                Console.WriteLine("---- Menu ----\n1. Age limited Store´s\n9. Exit\n");

                int selection = AskUserForNumber("your selection");

                switch (selection)
                {
                    case 1:
                        AgeLimitStors();
                        break;

                    case 9:
                        keepLooping = false;
                        Console.WriteLine("Thanks for youring this program.");
                        break;

                    default:
                        Console.WriteLine("Incorrect selection!");
                        break;
                }
                PressToContinue();
            }


        }//end of Main method

        static void AgeLimitStors()
        {
            /*
            string userAgeString = AskUserFor("your age");

            Console.WriteLine("You type in " + userAgeString + " as you age.");

            int userAge = Convert.ToInt32(userAgeString);
            */

            int userAge = AskUserForNumber("your age");

            if (userAge >= 18)
            {
                Console.WriteLine("Welcome to the bar and have a beer");
            }
            else
            {
                Console.WriteLine("Welcome to the candy store, want a lollipop?");
            }

        }

//      modifire - return type - name - parameter inputs
        static string AskUserFor(string what)
        {
            Console.Write("Please enter " + what + ": ");

            string userInput = Console.ReadLine();

            return userInput;
        }

        static int AskUserForNumber(string what)
        {
            bool wasNotNumber = true;
            int number = 0;
            do
            {
                wasNotNumber = ! int.TryParse(AskUserFor(what), out number);

            } while (wasNotNumber);

            return number;
        }

        static void PressToContinue()
        {
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

    }//end of program class
}//end of namespace
