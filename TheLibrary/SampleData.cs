using System.Linq;
using TheLibrary.Models;

namespace TheLibrary
{
    public static class SampleData
    {
        public static void Initialize(BookContext context)
        {
            if (!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book
                    {
                        Name = "Мастер и Маргарита",
                        Author = "Булгаков М.А.",
                        Genre = "роман"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}