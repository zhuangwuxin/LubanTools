using System;
using System.Xml.Serialization;

namespace LubanService
{
    [XmlRoot]
    [Serializable]
    public class LinkSetting
    {
        [XmlElement]
        public LinkURL Document = new LinkURL
        {
            url = "https://focus-creative-games.github.io/lubandoc/Home.html"
        };

        [XmlElement]
        public LinkURL Github = new LinkURL();

        [XmlElement]
        public LinkURL Gitee = new LinkURL();
    }

    public class LinkURL
    {
        [XmlAttribute]
        public string url;
    }
}