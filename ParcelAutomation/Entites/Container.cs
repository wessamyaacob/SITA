using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ParcelAutomation.Entites
{

    [XmlRoot(ElementName = "Container")]
    public class Container
    {
        [XmlElement(ElementName = "Id")]
        public int Id { get; set; }
        [XmlElement(ElementName = "ShippingDate")]
        public DateTime ShippingDate { get; set; }
        [XmlElement(ElementName = "parcels")]
        public Parcels Parcels { get; set; }
        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsi { get; set; }
        [XmlAttribute(AttributeName = "xsd", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsd { get; set; }
    }


    [XmlRoot(ElementName = "parcels")]
    public class Parcels
    {
        [XmlElement(ElementName = "Parcel")]
        public List<Parcel> Parcel { get; set; }
    }
}
