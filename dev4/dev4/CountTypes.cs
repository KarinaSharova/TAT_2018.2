using System;
using System.Collections.Generic;

namespace dev4
{
    //performs the action according to the command 'count types'
    public class CountTypes
    {
        //counts and outputs the count of types
        public void OutputTheCountOfTypes(List<string> brands)
        {
            //the count of types
            int typesCount = 0;
            List<string> uniqueBrands = new List<string>();

            //add only non-repeatable types
            foreach (var item in brands)
            {
                if (uniqueBrands.Contains(item) == false)
                    uniqueBrands.Add(item);
            }

            //count the number of types
            foreach (var item in uniqueBrands)
            {
                typesCount++;
            }
            Console.Write($"< Count of car types: {typesCount}\n\n> ");
        }
    }
}
