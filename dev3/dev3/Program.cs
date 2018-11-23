using System;
using System.Collections.Generic;

namespace dev3
{
    //converts an integer from the decimal system to another 
    //number system (from 2 to 20) and outputs it.
    class ConverterOfNumbers
    {
        static void Main(string[] args)
        {
            //entered integer in decimal system
            int startNumber;
            //derived converted number in another notation
            List<char> finishNumber = new List<char>();
            //notation (number system)
            int notation ;

            SignConverter signConverter = new SignConverter();

            //data input
            //an integer in decimal system input
            Console.WriteLine("Enter an integer in decimal system to convert : ");
        TryAgain1:
            try
            {
                startNumber = Int32.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("You entered an incorrect number, try again.");
                goto TryAgain1;
            }

            //notation input
            Console.WriteLine("Enter a notation to convert from 2 to 20 : ");
        TryAgain2:
            try
            {
                notation = Int32.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("You entered an incorrect number, try again.");
                goto TryAgain2;
            }

            string result = signConverter.TotalRecordOfTheConvertedNumber(notation, startNumber);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
