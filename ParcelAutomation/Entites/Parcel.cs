using System.Xml.Serialization;

namespace ParcelAutomation.Entites
{

    [XmlRoot(ElementName = "Parcel")]
    public class Parcel
    {
        [XmlElement(ElementName = "Sender")]
        public Sender Sender { get; set; }
        [XmlElement(ElementName = "Receipient")]
        public Receipient Receipient { get; set; }
        [XmlElement(ElementName = "Weight")]
        public double Weight { get; set; }
        [XmlElement(ElementName = "Value")]
        public double Value { get; set; }
    }

}
