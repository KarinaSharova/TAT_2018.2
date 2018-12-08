using System;
using System.Collections.Generic;

namespace Task1
{
    // counts and displays the number of each character in the sequence entered
    class Task1
    {
        // Entry point
        static void Main(string[] args)
        {
            NumbersOfIdencialCharacters numberOfIdencialCharacters = new NumbersOfIdencialCharacters();
            Console.WriteLine("Enter a sequence of characters: ");

            //character string introduction
            string sequenceOfCharacters = Console.ReadLine();
            //pairs(symbol / number of repetitions)
            Dictionary<char, int> idencialCharacters = new Dictionary<char, int>();

            idencialCharacters = numberOfIdencialCharacters.GetNumbersOfIdencialCharacters(sequenceOfCharacters);

            //output pairs(symbol / number of repetitions)
            foreach (KeyValuePair<char, int> keyValue in idencialCharacters)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
        }
    }
}
