using System;
using System.Collections.Generic;

namespace ProjectRest.Models {
    public class Author {
        public Guid Id {get; set;}
        public string LastName {get; set;}
        public string FirstName {get; set;}
        public DateTime DateOfBirth{get; set;}
        public string Genre {get; set;}
        public ICollection<Book> Books {get; set;} = new List<Book>();
    }
}