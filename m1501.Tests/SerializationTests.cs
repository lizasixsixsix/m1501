using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Xunit;
using Xunit.Abstractions;

namespace m1501.Tests
{
    public class SerializationTests
    {
        private readonly ITestOutputHelper _output;

        public SerializationTests(ITestOutputHelper output)
        {
            this._output = output;
        }

        [Fact]
        public void SerializationTest()
        {
            const string ns = "http://library.by/catalog";

            var serializer = new XmlSerializer(typeof(Catalog), ns);

            const string filename = @"Data\books_serialized.xml";

            using (var fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                var a = new Book
                {
                    Id = "a",
                    Genre = Genre.Fantasy,
                    PublishDate = DateTime.Today,
                    RegistrationDate = DateTime.Now,
                    Title = "Title A",
                    Author = "Author A",
                    Description = "Description A",
                    Isbn = "Isbn A",
                    Publisher = "Publisher A"
                };

                var b = new Book
                {
                    Id = "b",
                    Genre = Genre.ScienceFiction,
                    PublishDate = DateTime.Today,
                    RegistrationDate = DateTime.Now,
                    Title = "Title B",
                    Author = "Author B",
                    Description = "Description B",
                    Isbn = "Isbn B",
                    Publisher = "Publisher B"
                };

                var catalog = new Catalog { Books = new List<Book> { a, b } };

                fs.SetLength(0);

                serializer.Serialize(fs, catalog);
            }

            using (var reader = new StreamReader(filename))
            {
                _output.WriteLine(reader.ReadToEnd());
            }
        }
    }
}
