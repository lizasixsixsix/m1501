using System;
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
            const string ns = "http://library.by/catalog";

            var serializer = new XmlSerializer(typeof(Catalog), ns);

            using (var fs = new FileStream(@"Data\books.xml", FileMode.Open))
            {
                var catalog = (Catalog) serializer.Deserialize(fs);

                Assert.Equal(12, catalog.Books.Count);

                Assert.Equal(1, catalog.Books.Count(b => b.Genre == Genre.ScienceFiction));

                Assert.Contains(catalog.Books, b => b.Author == "Löwy, Juval");

                Assert.IsType<DateTime>(catalog.Books[0].PublishDate);

                Assert.IsType<DateTime>(catalog.Books[0].RegistrationDate);

                Assert.Equal(
                    "bk101",
                    catalog.Books
                        .SingleOrDefault(b => b.Title == "COM and .NET Component Services")?.Id);
            }
        }
    }
}
