using System;
using System.Collections.Generic;

namespace dev4
{
    //performs the action according to the command 'average price type'
    public class AveragePriceOfType
    {
        //counts and outputs the average cost of cars of the entered brand
        public void OutputTheAveragePriceOfType(List<string> brands, List<int> prices, string command)
        {
            //average price of cars of the entered brand
            double averageTypePriceValue = 0;
            //the number of all entered cars
            int countOfEnterData = 0;
            //the number of cars of this brand
            int countOfThisBrand = 0;

            //find out the brand specified in the command
            string type = command.Substring(14);

            foreach (var item in brands)
            {
                countOfEnterData++;
            }

            //add up the prices of cars of the introduced brand
            for (int i = 0; i < countOfEnterData; i++)
            {
                bool ifThisBrand = type.Equals(brands[i]);
                if (ifThisBrand)
                {
                    averageTypePriceValue += prices[i];
                    countOfThisBrand++;
                }
            }

            //find the average price of cars of the introduced brand
            averageTypePriceValue /= countOfThisBrand;

            if (countOfThisBrand > 0)
            {
                Console.Write($"< The average car cost of {type}: {averageTypePriceValue}\n\n> ");
            }
            else
                Console.Write("Uncorrected type. Try again.\n\n> ");        
        }
    }
}
