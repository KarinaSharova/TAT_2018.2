using System;
using System.Collections.Generic;

namespace dev8
{
    //performs the action according to the command 'count types'
    public class CountTypes : ICommand
    {
        //the count of types
        int typesCount = 0;
        //counts the count of types
        public int GetTheCountOfTypes(List<string> brands)
        {
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
            return typesCount;
        }

        //outputs the count of types
        public void OutputTheCountOfTypes()
        {
            Console.Write($"< Count of car types: {typesCount}\n\n> ");
        }

        public void Execute()
        {
            OutputTheCountOfTypes();
        }
    }
}
