using System;
using System.Linq;
using System.Collections.Generic;
using ProjectRest.Models;

namespace ProjectRest.Helper {
    public class ExampleDataHolder {
        private List<Author> _authorList;
        public ExampleDataHolder() {

            //Create some data
            _authorList = new List<Author>() {
                new Author(1, "Steve", "Jobs", DateTime.Now.AddYears(-23), "Thriller"),
                new Author(2, "Bill", "Gates", DateTime.Now.AddYears(-33), "Learn"),
                new Author(3, "Steve", "Wozniak", DateTime.Now.AddYears(-42), "Tutorial")
            };
        }
        public List<Author> GetAuthors() {
            return _authorList;
        }

        public Author GetAuthor(int id) {
            return _authorList.FirstOrDefault(author => author.Id == id);
        }
    }
}