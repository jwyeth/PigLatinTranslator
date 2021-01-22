using System;

namespace Capstone1PigLatinGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string goAgain = "y";
            string input;
            string output;

            Console.WriteLine("Welcome to the Pig Latin Translator!");

            while (goAgain == "y")
            {
                Console.Write("Please enter a word to be translated: ");
                input = Console.ReadLine();
                string lowerInput = input.ToLower();
                string firstLetter = lowerInput.Substring(0, 1);

                if (firstLetter == "a" || firstLetter == "i" || firstLetter == "e" || firstLetter == "o" || firstLetter == "u")
                {
                    output = lowerInput + "way";
                    Console.WriteLine(output);
                }
                else output = TranslateToPigLatin(lowerInput);

                Console.WriteLine(output);
                Console.Write("Would you like to translate another word? (y/n) ");

                goAgain = Console.ReadLine().ToLower();
            }
        }

        public static string TranslateToPigLatin(string lowerInput)
        {
         

            
            int index = lowerInput.IndexOfAny("aeiou".ToCharArray());

            if (index == -1)
                return "There doesn't seem to be any vowels.";
            else
            {
                string front = lowerInput.Substring(0, index);
                string back = lowerInput.Substring(index);
                string output = back + front + "ay";
                return output;
            }
        }
    }
}