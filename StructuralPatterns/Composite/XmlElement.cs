using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Composite
{
    class XmlElement
    {
        private readonly IList<XmlElement> _listChildren;
        private readonly XmlElement _parent;
        private readonly XmlNode _node;
        private readonly int _level;

        public XmlElement(System.Xml.XmlNode node, XmlElement parent, int level)
        {
            _listChildren = new List<XmlElement>();
            _node = node;
            _parent = parent;
            _level = level;
        }

        public XmlElement AddElement(string elementName, string value)
        {
            return AddElement(elementName, value, _parent);
        }

        private XmlElement AddElement(string elementName, string value, XmlElement parent)
        {
            var newNode = parent?.CurrentNode?.OwnerDocument?.CreateNode(System.Xml.XmlNodeType.Element, elementName, null) ??
                          _node?.OwnerDocument?.CreateNode(System.Xml.XmlNodeType.Element, elementName, null);

            if (newNode == null) throw new ArgumentNullException("Document not found.");
            newNode.InnerText = value;

            XmlElement newElement = new XmlElement(newNode, this, _level + 1);
            _listChildren.Add(newElement);

            return newElement;
        }

        public int Level => _level;
        public bool HasChildren => _listChildren.Count != 0;
        public IList<XmlElement> Children => _listChildren;
        public XmlNode CurrentNode => _node;

        public void ShowInfo()
        {
            Console.WriteLine(_node.Name + " " + _node.InnerText);
        }


    }
}
