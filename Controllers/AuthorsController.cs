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

            private  IDatabaseRepository _databaserepository;

            public AuthorController (IDatabaseRepository databaserepository) {
                _databaserepository = databaserepository;
            }

            [HttpGet()]
            public IActionResult GetAuthors() {

                var authors = _databaserepository.GetAuthors().ToList();
                var authorDtoList = new List<AuthorDto>();
                // create dto's and add to list
                authors.ForEach( author => authorDtoList.Add(new AuthorDto(author)));

                return Ok(authorDtoList);
            }

            [HttpGet("{id}")]
            public IActionResult GetAuthor(int id) {

                // get single user from 'database'
                //var tempAuthor = _dataholder.GetAuthor(id);

                // check on null refrence
                //if (tempAuthor == null) { 
                //    return  NotFound();
                //}
                
                //var authorDto = new AuthorDto(tempAuthor);
                //return Ok(authorDto);
                return Ok();
            }
        }
}
