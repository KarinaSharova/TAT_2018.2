using System;
using System.Collections.Generic;
using System.Xml;

namespace Task3
{
    // Gets information from xml file 'products' 
    class XmlParser
    {
        public int GetInformationFromXml(XmlElement xRoot, List<string> names,
            List<int> prices, List<string> types, List<int> expirationDate)
        {
            //counts the number of nodes and childnodes
            int nodeKey = 0;
            // traversals of all nodes in the root element
            foreach (XmlNode xnode in xRoot)
            {
                //s get attribute 'name'
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    if (attr != null)
                    {
                        names.Add(attr.Value);
                    }
                }
                // gos around all child nodes of the element 'product'
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    // if the node is 'type'
                    if (childnode.Name == "type")
                    {
                        types.Add(childnode.InnerText);
                    }
                    // if the node is 'price'
                    if (childnode.Name == "price")
                    {
                        prices.Add(Convert.ToInt32(childnode.InnerText));
                    }
                    // if the node is 'expirationDate'
                    if (childnode.Name == "price")
                    {
                        expirationDate.Add(Convert.ToInt32(childnode.InnerText));
                    }
                }
                nodeKey++;
            }
            return nodeKey;
        }
    }
}
