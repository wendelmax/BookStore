﻿using BookStore.Domain;
using BookStore.Mapping;
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AuthorMap());
            modelBuilder.Configurations.Add(new BookMap());
            modelBuilder.Configurations.Add(new CategoryMap());
        }
    }
}