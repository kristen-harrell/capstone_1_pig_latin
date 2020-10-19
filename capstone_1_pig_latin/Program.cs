using System;
using System.Linq.Expressions;
using System.Runtime.ExceptionServices;
using System.Security;
using System.Text;

namespace capstone_1_pig_latin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pig Latin Translator!");

            bool playAgain = true;

            while (playAgain)
            {
                Console.WriteLine();
                Console.Write("Enter anything you wish to translate:  ");

                string input = Console.ReadLine();
                string userInput = input.ToLower();

                Console.WriteLine();

                string[] splitArray = userInput.Split();

                Console.WriteLine("Here is your translation: ");
                Console.WriteLine();

                    foreach (string word in splitArray) 
                    {
                    int vowelLocation;
                    char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

                    vowelLocation = word.IndexOfAny(vowels);

                    if (vowelLocation == 0)
                    {
                        Console.Write($"{word}way ");
                    }

                    else if (vowelLocation == -1)

                    {
                        Console.Write($"{word}way ");
                    }

                    else
                    {
                        string lastHalf = word.Substring(vowelLocation);

                        string firstHalf = word.Substring(0, vowelLocation);

                        Console.Write($"{lastHalf}{firstHalf}ay ");
                    }

                }
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Would you like to translate something else? Enter y/n: ");
                string decision = Console.ReadLine();

                if (decision == "y")
                {
                    playAgain = true;
                }

                else
                {
                    Console.WriteLine("Ok, bye!");
                    break;
                }
            }

        }






    }
}
