﻿using System.Collections.Generic;

namespace BookStore.Domain
{
    public class Category
    {
        public Category()
        {
            this.Books = new HashSet<Book>();
        }

       
        public int Id { get; set; }

       
       
        public string Title { get; set; }

        public ICollection<Book> Books { get; set; }
        
    }
}