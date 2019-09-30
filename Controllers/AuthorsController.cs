using System;
using System.Net.Http;
using ProjectRest.Models;
using ProjectRest.Helper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ProjectRest 
{
        [Route("api/authors")]
        public class AuthorController : Controller {

            private ExampleDataHolder _dataholder;

            public AuthorController () {
                _dataholder = new ExampleDataHolder();
            }

            [HttpGet()]
            public IActionResult GetAuthors() {

                var tempList = new List<AuthorDto>();

                // get authors from 'database' ;-)
                var authors = _dataholder.GetAuthors();

                // create dto's and add to list
                authors.ForEach( x => tempList.Add(new AuthorDto(x)));

                return Ok(tempList);
            }

            [HttpGet("{id}")]
            public IActionResult GetAuthor(int id) {

                // get single user from 'database'
                var tempAuthor = _dataholder.GetAuthor(id);

                // check on null refrence
                if (tempAuthor == null) { 
                    return  NotFound();
                }
                
                var authorDto = new AuthorDto(tempAuthor);
                return Ok(authorDto);
            }
        }
}
