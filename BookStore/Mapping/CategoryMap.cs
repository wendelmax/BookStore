using BookStore.Domain;
using System.Data.Entity.ModelConfiguration;

namespace BookStore.Mapping
{
    public class CategoryMap 
        : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            ToTable("Categories");

            HasKey(x => x.Id);
            Property(x=>x.Title).HasMaxLength(30).IsRequired();

            HasMany(x => x.Books)
                .WithRequired(x => x.Category);
        }
    }
}