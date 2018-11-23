using System;
using System.Collections.Generic;
using System.Text;

namespace dev3
{
    public class SignConverter
    {
        //converts an integer from the decimal system to another according to its sign
        public string TotalRecordOfTheConvertedNumber(int notation, int startNumber)
        {
            List<char> finishNumber = new List<char>();
            ModuleConverter moduleConverter = new ModuleConverter();
            StringBuilder result = new StringBuilder("");

            //minimum and maximum number systems
            const int notationMin = 2;
            const int notationMax = 20;

            //positive numbers converting
            if (startNumber >= 0 && (notation >= notationMin && notation <= notationMax))
            {
                moduleConverter.Convert(notation, startNumber, finishNumber);
                for (int i = finishNumber.Count - 1; i >= 0; i--)
                    result.AppendFormat("{0}", finishNumber[i].ToString());
            }

            //negative numbers converting
            else if (startNumber < 0 && (notation >= notationMin && notation <= notationMax))
            {
                startNumber = -startNumber;
                moduleConverter.Convert(notation, startNumber, finishNumber);
                //int finishNumberSize = finishNumber.Count;
                //finishNumber.Insert(finishNumberSize, '-');
                result.AppendFormat("-"); 
                for (int i = finishNumber.Count - 1; i >= 0; i--)
                    result.AppendFormat("{0}", finishNumber[i].ToString());
            }

            //invalid number or number system
            if (notation < notationMin || notation > notationMax)
            {
                throw new ArgumentOutOfRangeException("Wrong notation.");
            }

            return result.ToString();
        }
    }
}
