using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryProject.Model;
using LibraryProject.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryProject.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {

        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            this._authorService = authorService;
        }


        [HttpGet("getallauthors")]
        public IActionResult GetAllAuthors()
        {

            return Ok(this._authorService.GetAllAuthors());
        }

        [HttpPost("addauthor")]
        public IActionResult AddAuthor(Author author)
        {
            return Ok(this._authorService.AddAuthor(author));
        }


        [HttpPut("updateauthor")]
        public IActionResult UpdateAuthor(Author author)
        {
            return Ok(this._authorService.UpdateAuthor(author));
        }

        [HttpDelete("deleteauthor/{authorId}")]
        public IActionResult DeleteAuthor(int authorid)
        {
            return Ok(this._authorService.DeleteAuthor(authorid));
        }

    }
}

