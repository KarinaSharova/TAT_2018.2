using System;
using System.Xml;
using System.Collections.Generic;

namespace Task3
{
    // uploads specific xml file 'products', displays products that meet specified conditions
    class Task3
    {
        // Entry point
        static void Main(string[] args)
        {
            //attributes 'name'
            List<string> names = new List<string>();
            //nodes 'type'
            List<string> types = new List<string>();
            //nodes 'price'
            List<int> prices = new List< int>();
            //nodes 'expirationDate'
            List<int> expirationDate = new List<int>();

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(@"C:\Users\Lenovo\Desktop\products.xml");
            // get the root element
            XmlElement xRoot = xDoc.DocumentElement;
            XmlParser xmlParser = new XmlParser();
            SuitableProducts suitProd = new SuitableProducts();

            // Gets information from xml file 'products' 
            xmlParser.GetInformationFromXml(xRoot, names, prices, types, expirationDate);

            // products that meet specified conditions
            List<string> suitableProducts = new List<string>();
            // gets products that meet specified conditions
            suitableProducts = suitProd.GetSuitableProducts(names, prices, types, expirationDate);

            // displays products that meet specified conditions         
            foreach (var item in suitableProducts)
            {
                Console.WriteLine(item);
            }
        }
    }
}

