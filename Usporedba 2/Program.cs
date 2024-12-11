using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Usporedba_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var prviXml = XDocument.Load("prvi.xml");
            var drugiXml = XDocument.Load("drugi.xml");

            // Parse books using the Book class
            var prviBooks = ParseBooks(prviXml);
            var drugiBooks = ParseBooks(drugiXml);

            // Find differences
            var onlyInPrvi = prviBooks.Except(drugiBooks);
            var onlyInDrugi = drugiBooks.Except(prviBooks);

            Console.WriteLine("Books only in prvi.xml:");
            foreach (var book in onlyInPrvi)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine("\nBooks only in drugi.xml:");
            foreach (var book in onlyInDrugi)
            {
                Console.WriteLine(book);
            }
        }

        static IEnumerable<Book> ParseBooks(XDocument doc)
        {
            return doc.Descendants("book").Select(book => new Book
            {
                Id = (string)book.Attribute("id"),
                Image = (string)book.Attribute("image"),
                Name = (string)book.Attribute("name")
            });
        }
    }

    }

