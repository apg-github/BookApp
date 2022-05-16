using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookApp.Models.DbModels
{
    public class Library
    {
        public int LibraryId{ get; set; }

        public string Name { get; set; }

        public List<Book> Books = new List<Book>();

        public Library() { }
        public Library(int libraryId, string name, List<Book> books)
        {
            LibraryId = libraryId;
            Name = name;
            Books = books;
        }
    }
}