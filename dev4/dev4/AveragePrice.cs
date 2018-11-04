using System;
using System.Collections.Generic;

namespace dev4
{
    //performs the action according to the command 'average price'
    public class AveragePrice
    {
        //counts and outputs the average cost of a car
        public void OutputTheAveragePrice(List<int> prices)
        {
            //average cost of a car
            double averagePriceValue = 0;
            //count of entered cars
            int countOfEnteredCars = 0;

            //add up the prices of cars 
            foreach (var item in prices)
            {
                averagePriceValue += item;
                countOfEnteredCars++;
            }

            //find the average price of cars 
            averagePriceValue /= countOfEnteredCars;
            Console.Write($"< The average car cost: {averagePriceValue}\n\n> ");
        }
    }
}
