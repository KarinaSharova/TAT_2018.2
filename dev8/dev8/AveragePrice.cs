using System;
using System.Collections.Generic;

namespace dev8
{
    //performs the action according to the command 'average price'
    public class AveragePrice : ICommand
    {
        //average cost of a car
        double averagePriceValue = 0;

        //counts the average cost of a car
        public void GetTheAveragePrice(List<int> prices)
        {
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
        }

        //outputs the average cost of a car
        public void OutputTheAveragePrice()
        {
            Console.Write($"< The average car cost: {averagePriceValue}\n\n> ");
        }

        public void Execute()
        {
            OutputTheAveragePrice();
        }
    }
}