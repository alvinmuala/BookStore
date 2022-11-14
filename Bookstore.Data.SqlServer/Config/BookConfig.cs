using BookStore.Domain.Config;
using BookStore.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bookstore.Data.SqlServer.Config
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Name)
                .HasColumnType("varchar(max)");

            builder.Property(b => b.Title)
             .HasColumnType("varchar(max)");

            builder.Property(b => b.Price)
               .HasColumnType("decimal(18,2)");

            // SEED DATA
            var defaultConfig = new DefaultConfig();
            builder.HasData(defaultConfig.Books);
        }
    }
}
