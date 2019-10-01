using System;
using ProjectRest.Models;

namespace ProjectRest.Models {
    public class AuthorDto {
        public Guid Id {get; set;}
        public string Name {get; set;}
        public int Age {get; set;}
        public string Genre {get; set;}

        // empty constructor for serialization
        public AuthorDto() {}
        public AuthorDto(Author author) {
            this.Id = author.Id;
            this.Name = author.FirstName + " " + author.LastName;
            this.Age = DateTime.Now.Year - author.DateOfBirth.Year;
            this.Genre = author.Genre;
        }
    }
}