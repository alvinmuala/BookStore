using Bookstore.Data.SqlServer.Config;
using BookStore.Domain.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Data.SqlServer
{
    public class Storage : IdentityDbContext<User>
    {
        public DbSet<Book> Books { get; set; } = null!;

        public Storage(DbContextOptions<Storage> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookConfig());
            base.OnModelCreating(modelBuilder);
        }

    }
}
