using BookStore.Domain;
using System.Data.Entity.ModelConfiguration;

namespace BookStore.Mapping
{
    public class AuthorMap
        : EntityTypeConfiguration<Author>
    {
        public AuthorMap()
        {
            ToTable("Authors");

            HasKey(x => x.Id);
            Property(x => x.Name).HasMaxLength(60).IsRequired();

            HasMany(x => x.Books)
                .WithMany(x => x.Authors)
                .Map(x => x.ToTable("BookAuthor"));
        }
    }
}