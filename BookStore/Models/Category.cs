using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Category
    {
        public Category()
        {
            this.Books = new HashSet<Book>();
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(30,MinimumLength =3,ErrorMessage ="Campo inválido")]
        public string Title { get; set; }

        public ICollection<Book> Books { get; set; }
        
    }
}