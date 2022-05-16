using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using BookApp.Models.DbModels;


namespace BookApp.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("BookAppConnectionString") { }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Library> Libraries { get; set; }
    }
}