using System.Collections.Generic;
using System;

namespace dev3
{
    public class ModuleConverter
    {
        //converts module of integer from the decimal system to another 
        public void Convert(int notation, int startNumber, List<char> finishNumber)
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
    }
}
