using System.Xml;
using System.Xml.Linq;

namespace htmlparser
{
    public class htmlparser
    {
        private XmlDocument _XmlDocument;
        private Dictionary<string, object> _htmlData;

        private void initObject(string htmlData)
        {
            _XmlDocument.LoadXml(htmlData);
            XmlNodeList nodes = _XmlDocument.ChildNodes;
            foreach (XmlNode node in nodes)
            {
                _htmlData.Add(node.Name, node.InnerText);
            }
        }
        public htmlparser(string htmlData)
        {
            _htmlData = new Dictionary<string, object>();
            _XmlDocument = new XmlDocument();
            initObject(htmlData);
        }

        public void changeNode(string htmlData)
        {
            initObject(htmlData);
        }

        private Dictionary<String, Object> parse()
        {
            return _htmlData;
        }

        public string? this[string tagName]
        {
            get
            {
                if (_htmlData.ContainsKey(tagName))
                {
                    return _htmlData[tagName].ToString();
                }
                return "error";
            }
        }

    }
}