using System;
using System.Collections.Generic;

namespace dev8
{
    //performs the action according to the command 'count all'
    public class CountAll : ICommand
    {
        //the count of all cars
        int countOfAll = 0;

        //counts the count of all cars
        public void GetTheCountOfAll(List<int> counts)
        {
            foreach (var i in counts)
                countOfAll = countOfAll + i;
            Console.Write($"< All count of cars: {countOfAll}\n\n> ");
        }

        //outputs the count of all cars
        public void OutputTheCountOfAll()
        {
            Console.Write($"< All count of cars: {countOfAll}\n\n> ");
        }

        public void Execute()
        {
            OutputTheCountOfAll();
        }
    }
}
