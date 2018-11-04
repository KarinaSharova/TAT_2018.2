using System;
using System.Collections.Generic;

namespace dev4
{
    //creates a records of the new cars, executes the entered commands
    public class EntryPoint
    {
        //The entry point of the program
        static void Main(string[] args)
        {
            NewCar car = new NewCar();
            Commands commands = new Commands();

            List<string> brands = new List<string>();
            List<string> models = new List<string>();
            List<int> counts = new List<int>();
            List<int> prices = new List<int>();

            //creates a records of the new cars
            car.CreateCar(brands, models, counts, prices);
            //executes the entered commands
            commands.PerformTheCommand(brands, models, counts, prices);
        }
    }
}
