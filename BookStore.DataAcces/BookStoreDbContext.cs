using BookStore.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DataAcces
{
    public class BookStoreDbContext : DbContext
    {
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options)
            : base(options) { }

      
        public BookStoreDbContext() { }

        public DbSet<Book> Books { get; set; }
    }
}
