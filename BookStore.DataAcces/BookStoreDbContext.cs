using BookStore.DataAcces.Entites;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DataAcces
{
    public class BookStoreDbContext : DbContext
    {
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) : base (options)
        {

        }
        public DbSet<BookEntity> Books { get; set; }

        
    }
}
