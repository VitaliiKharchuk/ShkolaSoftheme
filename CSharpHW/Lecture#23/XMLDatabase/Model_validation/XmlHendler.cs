using System;
using System.Xml.Linq;
using System.Linq;

namespace ValidationLibrary
{
    class XmlHendler
    {
        private readonly string fileTarget = @"Database.xml";

        public XmlHendler()
        {
            XDocument doc = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("Catalog",
                    new XElement("Books"),
                    new XElement("Users")
                ));

            doc.Save(fileTarget);
        }

        public void InsertBook(Book book)
        {
            XDocument doc = XDocument.Load(fileTarget);
            doc.Element("Catalog").Element("Books").Add(
                new XElement("Book",
                     new XElement("Id", book.Id.ToString()),
                     new XElement("Title", book.Title),
                     new XElement("Type", book.Type)
                )
                );

            doc.Save(fileTarget);
        }

        public void InsertUser(User user)
        {
            XDocument doc = XDocument.Load(fileTarget);
            doc.Element("Catalog").Element("Users").Add
                (
                new XElement("User",
                      new XElement("Id", user.Id),
                      new XElement("Name", user.Name),
                      new XElement("Age", user.Age),

                      new XElement("ListBooks",
                      from book in user.BooksFromLibrary
                      select new XElement("Book", book.Title)
                                 )
                           )
                );
            doc.Save(fileTarget);
        }

        public void DeleteBook(string title)
        {

            XDocument doc = XDocument.Load(fileTarget);
            doc.Root.Elements("Books").Elements().Where(x => x.Element("Title").Value == title).FirstOrDefault().Remove();
            doc.Save(fileTarget);
        }

        public void DeleteUser(string name)
        {
            XDocument doc = XDocument.Load(fileTarget);
            doc.Root.Elements("Users").Elements().Where(x => x.Element("Name").Value == name).FirstOrDefault().Remove();
            doc.Save(fileTarget);
        }

        public Book GetBook(string title)
        {
            XDocument doc = XDocument.Load(fileTarget);
            var foundBook = (from book in doc.Root.Elements("Books").Elements().Where(x => x.Element("Title").Value.Equals(title)) select book).FirstOrDefault();
            return foundBook == null ? default(Book) :
                new Book { Id = Convert.ToInt32(foundBook.Element("Id").Value), Title = foundBook.Element("Title").Value, Type = GetBookType(foundBook.Element("Type").Value) };
        }

        public User GetUser(string name)
        {

            XDocument doc = XDocument.Load(fileTarget);
            var foundUser = (from user in doc.Root.Elements("Users").Elements().Where(x => x.Element("Name").Value.Equals(name)) select user).FirstOrDefault();

            return foundUser == null ? default(User) : new User { Id = Convert.ToInt32(foundUser.Element("Id").Value), Age = Convert.ToInt32(foundUser.Element("Age").Value), Name = name };
        }

        public BookType GetBookType(string type)
        {
            switch (type)
            {
                case "Fiction": return BookType.Fiction;

                case "Drama": return BookType.Drama;

                case "NonFiction": return BookType.NonFiction;

                case "Fantasy": return BookType.Fantasy;

                case "Advanture": return BookType.Advanture;

                default: return BookType.Undefined;
            }
        }
    }
}






