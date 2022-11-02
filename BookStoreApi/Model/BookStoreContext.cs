using Microsoft.EntityFrameworkCore;
namespace BookStoreApi.Model
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerBook> CustomerBooks { get; set; }
    }
}
