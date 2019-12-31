using System.IO;
using System.Xml.Serialization;

namespace ParcelAutomation.Utility
{
    public class XMLFormatter
    {
        public static T Deserialize<T>(StreamReader streamReader)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            var obj = (T)serializer.Deserialize(streamReader);
            return obj;
        }
    }
}
