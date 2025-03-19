
using BookStore.Core.Models;
using BookStore.DataAcces.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.DataAcces.Configuration
{
    public class BookConfigiration : IEntityTypeConfiguration<BookEntity>
    {
        public void Configure(EntityTypeBuilder<BookEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(b => b.Title)
                .HasMaxLength(Book.MAX_TITLE_LENGHT)
                .IsRequired();

            builder.Property(b => b.Description)
               .IsRequired();

            builder.Property(b => b.Price)
                .IsRequired();

        }
    }
}
