using Microsoft.EntityFrameworkCore;
using COMP003B.Assignment6.Models;
namespace COMP003B.Assignment6.Data
{
    public class OnlineBookStore : DbContext
    {
        public OnlineBookStore(DbContextOptions<OnlineBookStoreContext> options) : base(options)
        {
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
    }
}
