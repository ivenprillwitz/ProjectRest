using System;

namespace ProjectRest {
    public class Author {
        public int Id {get; set;}
        public string Lastname {get; set;}
        public string Prename {get; set;}
        public DateTime DateOfBirth{get; set;}
        public string Genre {get; set;}

        public Author(int id,
                      string prename,
                      string lastname,
                      DateTime dateOfBirth,
                      string genre) {

            this.Id = id;
            this.Prename = prename;
            this.Lastname = lastname;
            this.DateOfBirth = dateOfBirth;
            this.Genre = genre;
        }
    }
}