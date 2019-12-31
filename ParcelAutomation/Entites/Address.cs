using System.Xml.Serialization;

namespace ParcelAutomation.Entites
{
    [XmlRoot(ElementName = "Address")]
    public class Address
    {
        [XmlElement(ElementName = "Street")]
        public string Street { get; set; }
        [XmlElement(ElementName = "HouseNumber")]
        public string HouseNumber { get; set; }
        [XmlElement(ElementName = "PostalCode")]
        public string PostalCode { get; set; }
        [XmlElement(ElementName = "City")]
        public string City { get; set; }
    }

}
