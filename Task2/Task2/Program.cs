using System;
using System.Collections.Generic;

namespace Task2
{
    class Task2
    {
        static void Main(string[] args)
        {
            IP ip = new IP();
            Console.WriteLine("Enter a sequence of characters: ");

            //character string introduction
            string sequenceOfCharacters = Console.ReadLine();
            List<string> pointIndices = new List<string>();
            pointIndices = ip.FindSequencesSimilarToIp(sequenceOfCharacters);

            //output all ip
            foreach (var item in pointIndices)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}

