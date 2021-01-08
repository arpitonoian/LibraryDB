using System;
using System.Linq;

namespace LibraryDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new LibraryContext())
            {

                var stdQuery = (from d in context.Books select new { Id = d.ID, Name = d.Name });
                var query = (from a in context.Authors select new { Id = a.AuthorID, FirstName = a.FirstName, ListName = a.ListName });
                foreach (var q in stdQuery)
                {
                    Console.WriteLine("ID : " + q.Id + " Name : " + q.Name);
                }

                Console.WriteLine();

                foreach (var q in query)
                {
                    Console.WriteLine("ID : " + q.Id + " FirstName : " + q.FirstName + " ListName : "+ q.ListName);
                }
                Console.ReadKey();
            }
        }
    }
}