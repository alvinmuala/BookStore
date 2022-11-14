using BookStore.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Data.SqlServer
{
    public class Storage : DbContext
    {
        public Storage(DbContextOptions<Storage> options) : base(options)
        {
        }

        DbSet<Book> Books { get; set; } = null!;
    }
}
