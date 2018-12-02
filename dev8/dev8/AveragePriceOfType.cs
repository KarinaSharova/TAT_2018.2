using System;
using System.Collections.Generic;

namespace dev8
{
    //performs the action according to the command 'average price type'
    public class AveragePriceOfType : ICommand
    {
        //average price of cars of the entered brand
        double averageTypePriceValue = 0;
        //the number of cars of this brand
        int countOfThisBrand = 0;

        //counts the average cost of cars of the entered brand
        public void GetTheAveragePriceOfType(List<string> brands, List<int> prices, string command)
        {
            //the number of all entered cars
            int countOfEnterData = 0;

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
        }

        //outputs the average cost of cars of the entered brand
        public void OutputTheAveragePriceOfType()
        {
            if (countOfThisBrand > 0)
            {
                Console.Write($"< The average car cost of: {averageTypePriceValue}\n\n> ");
            }
            //if the entered brand does not exist in the records
            else
                Console.Write("Uncorrected type. Try again.\n\n> ");
        }

        public void Execute()
        {
            OutputTheAveragePriceOfType();
        }
    }
}
