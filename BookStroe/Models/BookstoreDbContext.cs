using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStroe.Models
{
    public class BookstoreDbContext :DbContext
    {
        public BookstoreDbContext(DbContextOptions<BookstoreDbContext> options) : base(options)
        {
            
        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
