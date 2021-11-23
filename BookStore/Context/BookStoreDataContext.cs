using BookStore.Domain;
using System.Data.Entity;


namespace BookStore.Context
{
    public class BookStoreDataContext : DbContext
    {
        public BookStoreDataContext() 
            :base("BookStoreConnectionString")
        { }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories{ get; set; }
    }
}