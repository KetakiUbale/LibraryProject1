using LibraryProject.Model;
using LibraryProject.Service;
using LibraryProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryProject.Service
{
    public interface IBookService
    {

        IEnumerable<BookViewModel> GetAllBook();

        BookViewModel AddBook(BookViewModel book);
        Book GetById(int id);

      
        Book UpdateBook(Book book);
        bool DeleteBook(int bookId);


    }
}

        
