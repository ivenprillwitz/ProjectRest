using System;
using System.Collections.Generic;

namespace ProjectRest.Models
{
    public partial class Author
    {
        public Author()
        {
            Book = new HashSet<Book>();
        }

        public Guid Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Genre { get; set; }

        public virtual ICollection<Book> Book { get; set; }
    }
}
