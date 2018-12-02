using System;
using System.Collections.Generic;
using System.Xml;

namespace dev8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> carsBrands = new List< string>();
            List<string> carsModels = new List<string>();
            List<int> carsCounts = new List<int>();
            List<int> carsPrices = new List<int>();

            List<string> trucksBrands = new List<string>();
            List<string> trucksModels = new List<string>();
            List<int> trucksCounts = new List<int>();
            List<int> trucksPrices = new List<int>();

            XmlDocument docCars = new XmlDocument();
            docCars.Load(@"C:\Users\Lenovo\Desktop\TAT\TAT_2018\cars.xml");
            // get the root element
            XmlElement docCarsRoot = docCars.DocumentElement;

            XmlDocument docTrucks = new XmlDocument();
            docCars.Load(@"C:\Users\Lenovo\Desktop\TAT\TAT_2018\cars.xml");
            // get the root element
            XmlElement docTrucksRoot = docTrucks.DocumentElement;

            GettingInformationFromXml gettingInformationFromXml = new GettingInformationFromXml();
            gettingInformationFromXml.GetInformationFromXml(carsBrands, carsModels, carsCounts, carsPrices, docCarsRoot);
            gettingInformationFromXml.GetInformationFromXml(trucksBrands, trucksModels, trucksCounts, trucksPrices, docTrucksRoot);

            Console.WriteLine("\nIf you want to execute commands for cars, enter 1. If for trucks, enter 2.\nInput number: ");
            string number = Console.ReadLine();

            Commands commands = new Commands();
            switch (number)
            {
                case "1":
                    commands.PerformTheCommand(carsBrands, carsModels, carsCounts, carsPrices);
                    break;
                case "2":
                    commands.PerformTheCommand(trucksBrands, trucksModels, trucksCounts, trucksPrices);
                    break;
            }
        }
    }
}
