using System.IO;
using System.Linq;
using System.Xml.Serialization;
using Xunit;

namespace m1501.Tests
{
    public class DeserializationTests
    {
        [Fact]
        public void DeserializationTest()
        {
            var ns = "http://library.by/catalog";

            var serializer = new XmlSerializer(typeof(Catalog), ns);

            using (var fs = new FileStream(@"Data\books.xml", FileMode.Open))
            {
                var catalog = (Catalog) serializer.Deserialize(fs);

                Assert.Equal(12, catalog.Books.Count);

                Assert.Equal(4, catalog.Books.Count(b => b.Genre == "Computer"));

                Assert.Contains(catalog.Books, b => b.Author == "Löwy, Juval");
            }
        }
    }
}
