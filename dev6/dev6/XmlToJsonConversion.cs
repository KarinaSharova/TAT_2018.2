using System;
using System.Xml;

namespace dev6
{
    // Converts specific xml file 'users' to an json file
    class XmlToJsonConversion
    {
        public void ConvertXmlToJson(XmlElement xRoot)
        {
            Console.Write("{\n  \"root\":  {\n    \"users\":  [\n");
            // traversal of all nodes in the root element
            foreach (XmlNode xnode in xRoot)
            {
                Console.Write("      {\n");
                // get attribute 'name'
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    if (attr != null)
                    {
                        Console.WriteLine("         @\"name\":  \"{0}\",\n", attr.Value);
                    }
                }
                // go around all child nodes of the element 'user'
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    // if the node is 'company'
                    if (childnode.Name == "company")
                    {
                        Console.WriteLine("         \"company\":  \"{0}\",\n", childnode.InnerText);
                    }
                    // if the node is 'age'
                    if (childnode.Name == "age")
                    {
                        Console.WriteLine("         \"age\":  \"{0}\"\n", childnode.InnerText);
                    }
                }
                Console.WriteLine("      },");
            }
            Console.WriteLine("   ]");
            Console.WriteLine("}");
        }
    }
}
