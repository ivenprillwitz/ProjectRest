using System;
using System.Linq;
using System.Net.Http;
using ProjectRest.Models;
using ProjectRest.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ProjectRest {

    [Route("api/authors/{authorId}/books")]
    public class BooksController: Controller 
    {
        private IDirectoryService _service;
        public BooksController (IDirectoryService service) {
            _service = service;
        }

        [HttpGet()]
        public IActionResult GetBooksByAuthorId(Guid authorId) {

            var bookDtoList = new List<BookDto>();

            var books = _service.GetBooksByAuthorId(authorId).ToList();

            if (books.Any())
                books.ForEach( book => bookDtoList.Add(new BookDto(book)));

            return Ok(bookDtoList);
        }

        [HttpGet("{bookId}")]
        public IActionResult GetBookByAuthor(Guid authorId, Guid bookId) {
            
            var author = _service.GetAuthor(authorId);
            if (author == null)
                return NotFound();

            var bookFromAuthor = _service.GetBookByAuthor(authorId, bookId);
            if (bookFromAuthor == null)
                return NotFound();

            var bookDto = new BookDto(bookFromAuthor);
            return Ok(bookDto);
        }
    }
}