using System;
using System.Collections.Generic;

namespace dev3
{
    //converts an integer from the decimal system to another 
    //number system (from 2 to 20) and outputs it.
    class ConverterOfNumbers
    {
        //converts an integer from the decimal system to another 
        static void Conversion(int notation, int startNumber, List<char> finishNumber)
        {
            //key for conversion to number systems (up to 20)
            string key = "0123456789ABCDEFGHIJ";
            while (startNumber >= notation)
            {
                int i = startNumber % notation;
                finishNumber.Add(key[i]);
                startNumber = (startNumber - (startNumber % notation)) / notation;
            }
            finishNumber.Add(key[startNumber]);
        }

        //outputs received number in another number system
        static void LeadOut(List<char> finishNumber)
        {
            Console.WriteLine("Сonverted number : ");
            for (int i = finishNumber.Count - 1; i >= 0; i--)
            {
                Console.Write(finishNumber[i]);
            }
        }

        static void Main(string[] args)
        {
            //entered integer in decimal system
            int startNumber;
            //derived converted number in another notation
            List<char> finishNumber = new List<char>();
            //notation (number system)
            int notation;
            //minimum and maximum number systems
            const int notationMin = 2;
            const int notationMax = 20;

            //data input
            Console.WriteLine("Enter an integer in decimal system to convert : ");
            startNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter a notation to convert from 2 to 20 : ");
            notation = Int32.Parse(Console.ReadLine());

            //positive numbers converting
            if (startNumber >= 0 && (notation >= notationMin && notation <= notationMax))
            {
                Conversion(notation, startNumber, finishNumber);
                LeadOut(finishNumber);
            }

            //negative numbers converting
            else if (startNumber < 0 && (notation >= notationMin && notation <= notationMax))
            {
                startNumber = -startNumber;
                Conversion(notation, startNumber, finishNumber);
                Console.Write("-");
                LeadOut(finishNumber);
            }

            //invalid number or number system
            else
            {
                Console.Write("Mistake. You entered an invalid number or notation");
            }
            Console.ReadKey();
        }
    }
}
