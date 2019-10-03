using System;

namespace ProjectRest.Models {
    public class BookDto {
        public Guid Id { get; set; }
        public string Title { get; set;}
        public string Description {get; set;}
        public Guid AuthorId {get; set;}

        // empty constructor for serialization
        public BookDto() {}

        public BookDto (Book book) {
            this.Id = book.Id;
            this.Title = book.Title;
            this.Description = book.Description;
            this.AuthorId = book.AuthorId;
        }
    }
}