using System;

namespace Capstone1PigLatinGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pig Latin Translator!");

            string goAgain = "y";
            while (goAgain == "y")
            {
                Console.Write("Please enter a word to be translated: ");
                string input = Console.ReadLine();
                string lowerInput = input.ToLower();
                string output;


                string firstLetter = lowerInput.Substring(0, 1);
                string restOfSentence = lowerInput.Substring(1, lowerInput.Length - 1);
                //int isVowel = firstLetter.IndexOf(vowels);

                //if (lowerInput.Length == 1 && firstLetter == "a" || firstLetter == "i" || firstLetter == "e" || firstLetter == "o" || firstLetter == "u"))




                if (lowerInput.Length <= 1)
                {
                    Console.WriteLine("Please enter a word to translate.");
                }
                else if (firstLetter == "a" || firstLetter == "i" || firstLetter == "e" || firstLetter == "o" || firstLetter == "u")
                {
                    output = lowerInput + "way";
                    Console.WriteLine(output);
                }
                else if (lowerInput.Length <= 2)
                {
                    output = restOfSentence + firstLetter + "ay";
                    Console.WriteLine(output);
                }
                else
                {
                    int index = lowerInput.IndexOfAny("aeiou".ToCharArray());
                    Console.WriteLine(index);
                    string front = lowerInput.Substring(0, index);
                    string back = lowerInput.Substring(index);
                    //Console.WriteLine(front);
                    //Console.WriteLine(back);
                    //Console.WriteLine(index);
                    output = back + front + "ay";
                    Console.WriteLine(output);
                }

                Console.Write("Would you like to translate another word? (y/n) ");
                goAgain = Console.ReadLine();

                if (goAgain != "y")
                {
                    break;
                }

            }
        }

       /*public static string TranslateToPigLatin()
        {
                            string firstLetter = lowerInput.Substring(0, 1);
                string restOfSentence = lowerInput.Substring(1, lowerInput.Length - 1);

        }*/
    }
}
