using System.Collections.Generic;
using System.Xml;

namespace NordstromProbs
{
    public class XmlParser : IXmlParser
    {
        private XmlDocument _document;

        public void LoadXml(string xmlInput)
        {
            _document = new XmlDocument {PreserveWhitespace = false};
            _document.LoadXml(xmlInput);
        }

        public IEnumerable<string> FetchAttributesFromRoot(string rootNode, string attribute)
        {
            var xpathSelector = string.Format("//{0}//{1}", rootNode, attribute);
            var navigator = _document.CreateNavigator();
            var values = navigator.Select(xpathSelector);
            var result = new List<string>();
            while(values.MoveNext())
            {
                result.Add(values.Current.Value);
            }
            return result;
        }
    }
}