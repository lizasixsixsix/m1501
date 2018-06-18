using System.Collections.Generic;
using System.Xml.Serialization;

namespace m1501
{
    [XmlRoot("catalog")]
    public class Catalog
    {
        [XmlElement("book")]
        public List<Book> Books { get; set; }
    }
}
