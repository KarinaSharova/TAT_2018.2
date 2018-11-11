using System;
using System.Xml;

namespace dev6
{
    // uploads specific xml file 'users', converts this xml file to an json file
    class XmlToJson
    {
        // Entry point
        static void Main(string[] args)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(@"C:\Users\Lenovo\Desktop\TAT\TAT_2018.2\users.xml");
            // get the root element
            XmlElement xRoot = xDoc.DocumentElement;

            XmlToJsonConversion xmlToJsonConversion = new XmlToJsonConversion();
            xmlToJsonConversion.ConvertXmlToJson(xRoot);
            Console.Read();
        }
    }
}
