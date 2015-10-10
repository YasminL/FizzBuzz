using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

// The FizzBuzz Kata
// Write a program that prints the numbers from 1 to 100. 
// But for multiples of three print "Fizz" instead of the number and for the multiples of five print "Buzz". 
// For numbers which are multiples of both three and five print "FizzBuzz". 

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Welcome to this awesome app!**********");

            do
            {
                String numberAsString = getANumberFromUser();
                int numberAsInt;

                if (numberAsString == "exit")
                {
                    break;
                }
                else if (int.TryParse(numberAsString, out numberAsInt))
                {
                    Boolean isNumberBetweenOneAndHundred = checkIfNumberIsBetweenOneAndHundred(numberAsInt);

                    if (isNumberBetweenOneAndHundred)
                    {
                        Boolean isItAFizz = seeIfNumberIsMultipleOfThree(numberAsInt);
                        Boolean isItABuzz = seeIfNumberIsMultipleOfFive(numberAsInt);
                        Boolean isItNeitherAFizzOrABuzz = seeifNumberIsNoMultiple(numberAsInt);

                        returnFizzIfNumberIsMultipleOfThree(isItAFizz);
                        returnBuzzIfNumberIsMultipleOfFive(isItABuzz);
                        returnNumberIfNeitherFizzOrABuzz(isItNeitherAFizzOrABuzz, numberAsString);
                    }
                    else
                    {
                        getErrorMessageForNumbersOutOfRange();
                    }
                }
                else
                {
                    getErrorMessageForNotANumber();
                }
            }
            while (true);
        }

        private static String getANumberFromUser()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nWrite a number between 1 and 100: ");
            String numberAsString = Console.ReadLine();
            return numberAsString;
        }

        private static bool checkIfNumberIsBetweenOneAndHundred(int number)
        {
            if (number >= 1 && number <= 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static Boolean seeIfNumberIsMultipleOfFive(int number)
        {
            if (number % 5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static Boolean seeIfNumberIsMultipleOfThree(int number)
        {
            if (number % 3 == 0)
            {
                return true;
            }
            else
            {
                return false;
            };

        }

        private static bool seeifNumberIsNoMultiple(int number)
        {
            if (number % 3 != 0 && number % 5 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void returnFizzIfNumberIsMultipleOfThree(Boolean number)
        {
            if (number)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Fizz");
            }
        }

        private static void returnBuzzIfNumberIsMultipleOfFive(Boolean number)
        {
            if (number)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Buzz");
            }
        }

        private static void returnNumberIfNeitherFizzOrABuzz(Boolean numberFizzOrBuzz, String number)
        {
            if (numberFizzOrBuzz)
            {
                Console.WriteLine(number);
            }
        }

        private static void getErrorMessageForNotANumber()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nThat is not a number!");
        }

        private static void getErrorMessageForNumbersOutOfRange()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nNumber out of range!");
        }
    }
}
