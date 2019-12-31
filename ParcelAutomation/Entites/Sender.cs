using System.Xml.Serialization;

namespace ParcelAutomation.Entites
{

    [XmlRoot(ElementName = "Sender")]
    [XmlType(TypeName = "Company")]
    public class Sender
    {
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "Address")]
        public Address Address { get; set; }
        [XmlElement(ElementName = "CcNumber")]
        public string CcNumber { get; set; }
        [XmlAttribute(AttributeName = "type", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string Type { get; set; }
    }
}
