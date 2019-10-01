using System;
using System.Net.Http;
using ProjectRest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ProjectRest {

    [Route("api/authors/{authorId}/books")]
    public class BooksController: Controller {

        public BooksController () {}

        [HttpGet()]
        public IActionResult GetBooksByAuthorId(int authorId) {

            // Get author
            //var author = _dataholder.GetAuthor(authorId);

            // null check
            //if(author == null) {
            //    return NotFound();
            //}

            //var tempBookDtoList = new List<BookDto>();

            // looking for books
            //var books = author.Books;

            //books.ForEach( book => tempBookDtoList.Add(new BookDto(book)));

            //return Ok(tempBookDtoList);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetBookFromAuthor(int authorId, int id) {
            
            //var author = _dataholder.GetAuthor(authorId);
            //if (author == null)
            //    return NotFound();

            //var bookFromAuthor = _dataholder.GetBookFromAuthor(authorId, id);
            //if (bookFromAuthor == null)
            //    return NotFound();

            //return Ok(new BookDto(bookFromAuthor));
            return Ok();
        }
    }
}