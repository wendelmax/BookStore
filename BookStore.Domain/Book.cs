﻿using System;
using System.Collections.Generic;

namespace BookStore.Domain
{
    public class Book //POCO Livro
    {
        public Book()
        {
            this.Authors = new HashSet<Author>();
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string ISBN { get; set; }

        public DateTime PublicationDate { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public ICollection<Author> Authors { get; set; }
    }
}