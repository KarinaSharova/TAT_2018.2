using System;
using System.Collections.Generic;

namespace dev4
{
    //performs the action according to the command 'count all'
    public class CountAll
    {
        //counts and outputs the count of all cars
        public void ShowTheCountOfAll(List<int> counts)
        {
            //the count of all cars
            int countOfAll = 0;

            foreach (var i in counts)
                countOfAll = countOfAll + i;
            Console.Write($"< All count of cars: {countOfAll}\n\n> ");
        }
    }
}
