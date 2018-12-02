using System;
using System.Collections.Generic;

namespace dev8
{
    //class that accepts and recognizes the entered commands and provides the necessary information
    public class Commands
    {
        //this method checks which command is entered and provides information on the requested commands
        public void PerformTheCommand(List<string> brands, List<string> models, List<int> counts, List<int> prices)
        {
            CountAll countOfAll = new CountAll();
            CountTypes countOfTypes = new CountTypes();
            AveragePrice averagePrice = new AveragePrice();
            AveragePriceOfType averagePriceOfType = new AveragePriceOfType();

            string commandExit = "exit";
            bool ifExit = false;

            Console.Write("\nIf you want to add another car enter 'add car'. " +
                    "Enter 'count types', 'count all', 'average price', 'average price type' " +
                    "if you want to get this information. Enter 'exit' if you want to exit the program.\n\n> ");

            //requests commands and displays the necessary information
            while (ifExit != true)
            {
                string command = Console.ReadLine();
                int indexOfCommandAveragePriceType = -1;
                ifExit = command.Equals(commandExit);

                //performs actions according to the entered command
                if (command.Equals("count types"))
                {
                    countOfTypes.OutputTheCountOfTypes();
                }
                if (command.Equals("count all"))
                {
                    countOfAll.OutputTheCountOfAll();
                }
                if (command.Equals("average price"))
                {
                    averagePrice.OutputTheAveragePrice();
                }
                if (command.Contains("average price "))
                {
                    indexOfCommandAveragePriceType = command.IndexOf("average price ");
                    if (indexOfCommandAveragePriceType == 0)
                        averagePriceOfType.OutputTheAveragePriceOfType();
                    else
                        Console.Write("Uncorrected type. Try again.\n\n> ");
                }
                if (ifExit)
                {
                    break;
                }
                //if incorrect command is entered
                else
                {
                    Console.Write("Invalid command. Try again.\n\n> ");
                }
            }
        }
    }
}
