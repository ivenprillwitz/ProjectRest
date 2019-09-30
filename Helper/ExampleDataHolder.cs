using System;
using System.Linq;
using System.Collections.Generic;
using ProjectRest.Models;

namespace ProjectRest.Helper {
    public class ExampleDataHolder {

        private List<Author> _authorList;

        public ExampleDataHolder() {

            var steve = new Author(1, "Steve", "Jobs", DateTime.Now.AddYears(-23), "Thriller");
            var bill = new Author(2, "Bill", "Gates", DateTime.Now.AddYears(-33), "Learn");
            var wozniak = new Author(3, "Steve", "Wozniak", DateTime.Now.AddYears(-42), "Tutorial");

            var steveBooks = new List<Book>() { new Book(1, "Becoming Steve Jobs", "Description", steve),
                                                new Book(2, "How to make Apple?", "Description", steve)};
            steve.Books = steveBooks;

            var billBooks  = new List<Book>() { new Book(1, "Becoming Bill Gates", "Description", bill),
                                                new Book(2, "How to make MS?", "Description", bill)};

            bill.Books = billBooks;

            var wozniakBooks =  new List<Book>() { new Book(1, "Becoming Steve Wozniak", "Description", wozniak),
                                                   new Book(2, "How to make Computer?", "Description", wozniak)};  

            wozniak.Books = wozniakBooks;


            _authorList = new List<Author>() {steve, bill, wozniak};
        }
        public List<Author> GetAuthors() {
            return _authorList;
        }

        public Author GetAuthor(int id) {
            return _authorList.FirstOrDefault(author => author.Id == id);
        }

        public Book GetBookFromAuthor(int authorId, int bookId) {
            var author = _authorList.FirstOrDefault(x => x.Id == authorId);

            if (author == null)
                return null;

            var book = author.Books.FirstOrDefault(x => x.Id == bookId);
            return book;
        }
    }
}