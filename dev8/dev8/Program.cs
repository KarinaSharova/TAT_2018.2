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

            Commands commands = new Commands();
            commands.PerformTheCommand(brands, models, counts, prices);
        }
    }
}
