using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Composite
{
    class XmlDocument
    {
        private readonly System.Xml.XmlDocument _doc;
        private readonly XmlElement _baseElement;


        public XmlDocument(string baseNodeName, string baseNodeValue)
        {
            _doc = new System.Xml.XmlDocument();

            var baseNode = _doc.CreateNode(System.Xml.XmlNodeType.Element, baseNodeName, null);
            baseNode.InnerText = baseNodeValue;

            _baseElement = new XmlElement(baseNode, null, 0);
        }

        public XmlElement AddElement(string elementName, string value)
        {
            return _baseElement.AddElement(elementName, value);
        }

        public void ShowDocument()
        {
            this.ShowDocument(_baseElement);
        }

        private void ShowDocument(XmlElement element)
        {
            if (element.Level == 0)
                Console.WriteLine($"<{_baseElement.CurrentNode.Name}>{_baseElement.CurrentNode.InnerText}</{_baseElement.CurrentNode.Name}>");

            if (element.HasChildren)
                foreach (XmlElement item in element.Children)
                {
                    for (int i = 0; i < item.Level; i++)
                        Console.Write("\t");

                    Console.WriteLine($"<{item.CurrentNode.Name}>{item.CurrentNode.InnerText}</{item.CurrentNode.Name}>");
                    ShowDocument(item);
                }
        }

    }
}
