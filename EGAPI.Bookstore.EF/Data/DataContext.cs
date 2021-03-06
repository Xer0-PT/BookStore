using Microsoft.EntityFrameworkCore;
using EGAPI.Bookstore.Domain.Models;

namespace EGAPI.Bookstore.EF.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }


        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}