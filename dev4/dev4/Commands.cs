using System;
using System.Collections.Generic;

namespace dev4
{
    //class that accepts and recognizes the entered commands and provides the necessary information
    public class Commands
    {
        //this method checks which command is entered and provides information on the requested commands
        public void PerformTheCommand(List<string> brands, List<string> models, List<int> counts, List<int> prices)
        {
            NewCar newCar = new NewCar();
            CountAll countOfAll = new CountAll();
            CountTypes countOfTypes = new CountTypes();
            AveragePrice averagePrice = new AveragePrice();
            AveragePriceOfType averagePriceOfType = new AveragePriceOfType();

            //used to recognize the entered command
            string commandAdd = "add car";
            string commandCountTypes = "count types";
            string commandCountAll = "count all";
            string commandAveragePrice = "average price";
            string commandAveragePriceType = "average price ";
            string commandExit = "exit";

            bool ifExit = false;

            Console.Write("\nIf you want to add another car enter 'add car'. " +
                    "Enter 'count types', 'count all', 'average price', 'average price type' " +
                    "if you want to get this information. Enter 'exit' if you want to exit the program.\n\n> ");

            //requests commands and displays the necessary information
            while (ifExit != true)
            {
                string command = Console.ReadLine();

                //compares the entered command with existing
                bool ifAdd = command.Equals(commandAdd);
                bool ifCountTypes = command.Equals(commandCountTypes);
                bool ifCountAll = command.Equals(commandCountAll);
                bool ifAveragePrice = command.Equals(commandAveragePrice);
                bool ifAveragePriceType = command.Contains(commandAveragePriceType);
                int indexOfCommandAveragePriceType = -1;

                ifExit = command.Equals(commandExit);

                //performs actions according to the entered command
                if (ifAdd)
                {
                    newCar.CreateCar(brands, models, counts, prices);
                    Console.Write("\n> "); 
                }
                if (ifCountTypes)
                {
                    countOfTypes.OutputTheCountOfTypes(brands);
                }
                if (ifCountAll)
                {
                    countOfAll.ShowTheCountOfAll(counts);
                }
                if (ifAveragePrice)
                {
                    averagePrice.OutputTheAveragePrice(prices);
                }
                if (ifAveragePriceType)
                {
                    indexOfCommandAveragePriceType = command.IndexOf(commandAveragePriceType);
                    if (indexOfCommandAveragePriceType == 0)
                        averagePriceOfType.OutputTheAveragePriceOfType(brands, prices, command);
                    else
                        Console.Write("Uncorrected type. Try again.\n\n> ");
                }
                if (ifExit)
                {
                    break;
                }
                //if incorrect command is entered
                if (!ifExit && !ifAdd & !ifCountTypes && !ifCountAll && !ifAveragePrice && indexOfCommandAveragePriceType != 0)
                {
                    Console.Write("Invalid command. Try again.\n\n> ");
                }
            }
        }
    }
}
