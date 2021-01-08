namespace LibraryDB.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<LibraryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "LibraryDB.LibraryContext";
        }

        protected override void Seed(LibraryContext context)
        {
            context.Books.Add(new Book() { Name = "Design Patterns" });
            context.Books.Add(new Book() { Name = "Introduction to Object Orient Design in C++" });
            context.Books.Add(new Book() { Name = "Contributing to Eclipse: Principles, Patterns, and Plug-ins" });
            context.Books.Add(new Book() { Name = "A Lost Age" });

            context.Authors.Add(new Author { FirstName = " Erich", ListName = "Gamma" });
            context.Authors.Add(new Author { FirstName = " Ralph", ListName = "'Johnson" });
            context.Authors.Add(new Author { FirstName = " Richard", ListName = "Richard" });
        }
    }
}
