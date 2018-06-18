using System;
using System.Xml.Serialization;

namespace m1501
{
    [Serializable, XmlRoot("book")]
    public class Book
    {
        // public string Id { get; set; }

        [XmlElement("isbn")]
        public string Isbn { get; set; }

        [XmlElement("author")]
        public string Author { get; set; }

        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("genre")]
        public string Genre { get; set; }
        // public Genre Genre { get; set; }

        [XmlElement("publisher")]
        public string Publisher { get; set; }

        [XmlElement("publish_date")]
        public string PublishDate { get; set; }
        // public DateTime PublishDate { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("registration_date")]
        public string RegistrationDate { get; set; }
        // public DateTime RegistrationDate { get; set; }
    }
}
