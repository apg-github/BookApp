using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookApp.Models.DbModels
{
    public class Author
    {
        public int AuthorId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public List<Book> Books = new List<Book>();

        public Author() { }
        public Author(int authorId, string name, string surname, List<Book> books)
        {
            AuthorId = authorId;
            Name = name;
            Surname = surname;
            Books = books;
        }
    }
}