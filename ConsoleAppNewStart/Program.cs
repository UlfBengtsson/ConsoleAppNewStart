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
                Console.WriteLine("---- Menu ----"
                                  +"\n1. Age limited Store´s"
                                  +"\n2. Count down"
                                  +"\n3. Same but diffrent"
                                  +"\n4. Date Time"
                                  +"\n4. Plus operator and friends"
                                  +"\n9. Exit\n"
                                  );

                int selection = AskUserForNumber("your selection");

                switch (selection)
                {
                    case 1:
                        AgeLimitStors();
                        break;

                    case 2:
                        CountDown();
                        break;

                    case 3:
                        DiffrentButSame();
                        break;

                    case 4:
                        DateTimePrinting();
                        break;

                    case 5:
                        PlusOperatorModes();
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

        static void PlusOperatorModes()
        {
            string putTogether = "it " + "works";
            Console.WriteLine(putTogether);
            
            double result = 1.2 + 3;
            Console.WriteLine(result);

            char startSymbol = 'g';
            Console.WriteLine(1 + startSymbol);

            Console.WriteLine(((short)startSymbol));
        }

        static void DateTimePrinting()
        {
            DateTime today = DateTime.Now;

            Console.WriteLine(today);
            Console.WriteLine(today.Date);
            Console.WriteLine(today.Date.ToLongDateString());
            Console.WriteLine(today.Date.ToShortDateString());
        }

        static void DiffrentButSame()
        {
            double number1 = 1;
            double number2 = 3;
            double result = number1 / number2;

            Console.WriteLine(number1 + " / " + number2 + " = " + result);

            Console.WriteLine("{0} / {1} = {2}" , number1, number2, result);

            Console.WriteLine($"{number1} / {number2} = {result}");

            Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
        }

        static void CountDown()
        {
            int startNumber = AskUserForNumber("number to count down from");

            for (int i = startNumber; i > 0; i--)
            {
                Console.WriteLine("Number: " + i);
            }
        }

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
            Console.ReadKey(true);
        }

    }//end of program class
}//end of namespace
