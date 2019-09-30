using System;

namespace ProjectRest.Models {
    public class Book {
        public int Id { get; set; }
        public string Title { get; set;}
        public string Description {get; set;}
        public Author Author {get; set;}

        public Book (int id,
                     string title,
                     string description,
                     Author author)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.Author = author;
        }
    }
}