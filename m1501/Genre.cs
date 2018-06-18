using System.Xml.Serialization;

namespace m1501
{
    public enum Genre
    {
        Computer,
        Fantasy,
        Romance,
        Horror,
        [XmlEnum(Name = "Science Fiction")]
        ScienceFiction
    }
}
