using System.Configuration;
using System.Data.Entity;

namespace LibraryDB
{
    public class LibraryContext : DbContext
    {
        public LibraryContext() : base(ConfigurationManager.ConnectionStrings["LibraryContext"].ConnectionString)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
