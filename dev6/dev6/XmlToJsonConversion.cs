using System.Xml;
using System.Collections.Generic;

namespace dev6
{
    // Converts specific xml file 'users' to an json file
    class XmlToJsonConversion
    {
        public int ConvertXmlToJson(XmlElement xRoot, Dictionary<int, string> names, 
            Dictionary<int, string> companies, Dictionary<int, string> ages)
        {
            //counts the number of nodes anad childnodes
            int nodeKey = 0;
            // traversal of all nodes in the root element
            foreach (XmlNode xnode in xRoot)
            {
                // get attribute 'name'
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    if (attr != null)
                    {
                        names.Add(nodeKey, attr.Value);
                    }
                }
                // go around all child nodes of the element 'user'
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    // if the node is 'company'
                    if (childnode.Name == "company")
                    {
                        companies.Add(nodeKey, childnode.InnerText);
                    }
                    // if the node is 'age'
                    if (childnode.Name == "age")
                    {
                        ages.Add(nodeKey, childnode.InnerText);
                    }
                }
                nodeKey++;
            }
            return nodeKey;
        }
    }
}
