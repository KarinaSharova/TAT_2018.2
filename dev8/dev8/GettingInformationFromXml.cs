using System.Xml;
using System;
using System.Collections.Generic;

namespace dev8
{
    // Converts specific xml file 'cars' or 'trucks' 
    public class GettingInformationFromXml
    {
        public void GetInformationFromXml(List<string> brands, List<string> models, List<int> counts, List<int> prices, XmlElement xRoot)
        {
            // traversal of all nodes in the root element
            foreach (XmlNode xnode in xRoot)
            {
                // go around all child nodes of the element 'cars' or 'trucks'
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    // if the node is 'brand'
                    if (childnode.Name == "brand")
                    {
                        brands.Add(childnode.InnerText);
                    }
                    // if the node is 'model'
                    if (childnode.Name == "model")
                    {
                        models.Add(childnode.InnerText);
                    }
                    // if the node is 'count'
                    if (childnode.Name == "count")
                    {
                        counts.Add(Convert.ToInt32(childnode.InnerText));
                    }
                    // if the node is 'price'
                    if (childnode.Name == "price")
                    {
                        prices.Add(Convert.ToInt32(childnode.InnerText));
                    }
                }
            }
        }
    }
}