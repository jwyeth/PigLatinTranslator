using System;

namespace Capstone1PigLatinGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string goAgain = "y";
            string input;
            
            Console.WriteLine("Welcome to the Pig Latin Translator!");

            while (goAgain == "y")
            {
                Console.Write("Please enter a word to be translated: ");
                input = Console.ReadLine();
                string lowerInput = input.ToLower();

                TranslateToPigLatin(lowerInput);

                Console.Write("Would you like to translate another word? (y/n) ");
                goAgain = Console.ReadLine().ToLower();
            }
        }

        public static void TranslateToPigLatin(string lowerInput)
        {

            String[] words = lowerInput.Split();

            for (int i = 0; i < words.Length; i++)
            {
                int index = words[i].IndexOfAny("aeiou".ToCharArray());

                if (index == 0)
                {
                    Console.WriteLine(words[i] + "way");
                }
                else
                {
                    string front = words[i].Substring(0, index);
                    string back = words[i].Substring(index);

                    Console.WriteLine(back + front + "ay");
                }
            }
        }
    }
}