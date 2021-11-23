using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Domain
{
    public class Author
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