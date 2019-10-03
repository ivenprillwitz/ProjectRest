using System;
using System.Net.Http;
using ProjectRest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ProjectRest.Services;
using System.Linq;

namespace ProjectRest 
{
    [Route("api/authors")]
    public class AuthorController : Controller {

        private  IDirectoryService _service;

        public AuthorController (IDirectoryService service) {
            _service = service;
        }

        [HttpGet()]
        public IActionResult GetAuthors() {

            var authorDtoList = new List<AuthorDto>();

            var authors = _service.GetAuthors().ToList();
            authors.ForEach( author => authorDtoList.Add(new AuthorDto(author)));

            return Ok(authorDtoList);
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthor(Guid id) {

            var author = _service.GetAuthor(id);

            if(author is null)
                return NotFound();
                
            var authorDto = new AuthorDto(author);
            return Ok(authorDto);
        }
    }
}
