using System;
using System.Collections.Generic;

namespace Task2
{
    class Task2
    {
        static void Main(string[] args)
        {
            IP ip = new IP();
            //character string introduction
            string sequenceOfCharacters = "dshb123.4.56.1nbv";
            List<string> ipSequence = new List<string>();
            ipSequence = ip.FindSequencesSimilarToIp(sequenceOfCharacters);

            //output all ip
            foreach (var item in ipSequence)
            {
                Console.WriteLine(item);
            }
        }
    }
}

