using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Bookshop.Models
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<Purchase> Purchases { get; set; }
    }

    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "Brave New World", Author = "Aldous Huxley", Price = 200 });
            db.Books.Add(new Book { Name = "Fight Club", Author = "Chuck Palahniuk", Price = 210 });
            db.Books.Add(new Book { Name = "Fahrenheit 451", Author = "Ray Bradbury - Fahrenheit 451", Price = 220 });

            base.Seed(db);
        }
    }
}