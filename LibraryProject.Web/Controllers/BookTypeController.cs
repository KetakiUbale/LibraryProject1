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
    public class BookTypeController : ControllerBase
    {
        private readonly IBookTypeService _booktypeService;

        public BookTypeController(IBookTypeService booktypeService)
        {
            this._booktypeService = booktypeService;
        }


        [HttpGet("getallbooktype")]
        public IActionResult GetAllBookType()
        {

            return Ok(this._booktypeService.GetAllBookType());
        }

        [HttpPost("addbooktype")]
        public IActionResult AddBookType(BookType booktype)
        {
            return Ok(this._booktypeService.AddBookType(booktype));
        }


        [HttpPut("updatebooktype")]
        public IActionResult UpdateBookType(BookType booktype)
        {
            return Ok(this._booktypeService.UpdateBookType(booktype));
        }

        [HttpDelete("deletebooktype/{booktypeId}")]
        public IActionResult DeleteBookType(int booktypeid)
        {
            return Ok(this._booktypeService.DeleteBookType(booktypeid));
        }

    }
}

