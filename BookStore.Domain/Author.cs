﻿using System.Collections.Generic;

namespace BookStore.Domain
{
    public class Author //POCO Autor
    {
        public Author()
        {
            this.Books = new HashSet<Book>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}