using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookApp.Models.DbModels
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public BookType BookType { get; set; }

        public Book() { }

        public Book(int bookId, string title, BookType bookType)
        {
            BookId = bookId;
            Title = title;
            BookType = bookType;
        }

        public int AuthorId;
        public  Author Author;
        public  int LibraryId;
        public  Library Library;
    }

    public enum BookType { Fantasy, Other }
}