namespace ProjectRest.Models {
    public class BookDto {
        public int Id { get; set; }
        public string Title { get; set;}
        public string Description {get; set;}
        public int AuthorId {get; set;}

        // empty constructor for serialization
        public BookDto() {}

        public BookDto (Book book) {
            this.Id = book.Id;
            this.Title = book.Title;
            this.Description = Description;
            this.AuthorId = book.Author.Id;
        }
    }
}