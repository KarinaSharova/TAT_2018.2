using System;
using System.Xml;
using System.Collections.Generic;

namespace dev6
{
    // uploads specific xml file 'users', converts this xml file to an json file
    class XmlToJson
    {
        // Entry point
        static void Main(string[] args)
        {
            //attributes 'name'
            Dictionary<int, string> names = new Dictionary<int, string>();
            //nodes 'company'
            Dictionary<int, string> companies = new Dictionary<int, string>();
            //nodes 'age'
            Dictionary<int, string> ages = new Dictionary<int, string>();

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(@"C:\Users\Lenovo\Desktop\TAT\TAT_2018.2\users.xml");
            // get the root element
            XmlElement xRoot = xDoc.DocumentElement;

            XmlToJsonConversion xmlToJsonConversion = new XmlToJsonConversion();
            int namesCount = xmlToJsonConversion.ConvertXmlToJson(xRoot, names, companies, ages);
            int nodeKey = 0;

            //outputs json-file
            Console.Write("{\n  \"root\":  {\n    \"users\":  [\n      {\n");
            foreach (var item in names)
            {
                Console.WriteLine("         @\"name\":  \"{0}\",\n", names[nodeKey]);
                Console.WriteLine("         \"company\":  \"{0}\",\n", companies[nodeKey]);
                Console.WriteLine("         \"age\":  \"{0}\"", ages[nodeKey]);

                nodeKey++;
                if (nodeKey == namesCount)
                    break;
                Console.Write("      },\n      {\n");
            }
            Console.Write("      }\n   ]\n}");
        }
    }
}
