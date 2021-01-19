using LibraryProject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryProject.Service
{
    public interface IBookTypeService
    {
        IEnumerable<BookType> GetAllBookType();
        BookType GetById(int id);
        
        BookType AddBookType(BookType booktype);
        BookType UpdateBookType(BookType booktype);
        bool DeleteBookType(int booktypeId);


    }
}
