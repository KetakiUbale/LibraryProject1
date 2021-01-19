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
    public class BookController : ControllerBase
    {

        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
            {
                this._bookService = bookService;
            }


            [HttpGet("getallbooks")]
            public IActionResult GetAllBook()
            {

            return Ok(this._bookService.GetAllBook());
            }

            [HttpPost("addbook")]
            public IActionResult AddBook(Book book)
            {
                return Ok(this._bookService.AddBook(book));
            }


            [HttpPut("updatebook")]
            public IActionResult UpdateBook(Book book)
            {
                return Ok(this._bookService.UpdateBook(book));
            }

            [HttpDelete("deletebook/{bookId}")]
            public IActionResult DeleteBook(int bookid)
            {
                return Ok(this._bookService.DeleteBook(bookid));
            }

        }
    }

