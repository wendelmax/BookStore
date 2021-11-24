using BookStore.Domain;
using System.Data.Entity.ModelConfiguration;

namespace BookStore.Mapping
{
    public class BookMap
        : EntityTypeConfiguration<Book>
    {
        public BookMap()
        {
            ToTable("Books");

            HasKey(x => x.Id);
            Property(x => x.Title).HasMaxLength(50).IsRequired();
            Property(x => x.ISBN).HasMaxLength(32).IsRequired();
            Property(x => x.PublicationDate).IsRequired();
        }
    }
}