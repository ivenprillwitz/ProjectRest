using System;
using System.Net.Http;
using ProjectRest.Models;
using ProjectRest.Helper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ProjectRest {

    [Route("api/authors/{authorId}/books")]
    public class BooksController: Controller {

        private ExampleDataHolder _dataholder;

        public BooksController () {
            _dataholder = new ExampleDataHolder();
        }

        [HttpGet()]
        public IActionResult GetBooksByAuthorId(int authorId) {

            // Get author
            var author = _dataholder.GetAuthor(authorId);

            // null check
            if(author == null) {
                return NotFound();
            }

            var tempBookDtoList = new List<BookDto>();

            // looking for books
            var books = author.Books;

            books.ForEach( book => tempBookDtoList.Add(new BookDto(book)));

            return Ok(tempBookDtoList);
        }
    }
}