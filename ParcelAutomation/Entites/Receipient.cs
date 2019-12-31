using System.Xml.Serialization;

namespace ParcelAutomation.Entites
{

    [XmlRoot(ElementName = "Receipient")]
    public class Receipient
    {
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "Address")]
        public Address Address { get; set; }
    }

}
