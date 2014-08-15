using System.Collections.Generic;

namespace NordstromProbs
{
    public interface IXmlParser
    {
        void LoadXml(string xmlInput);
        IEnumerable<string> FetchAttributesFromRoot(string rootNode, string attribute);
    }
}