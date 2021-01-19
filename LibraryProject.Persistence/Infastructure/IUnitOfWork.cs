using LibraryProject.Model;
using LibraryProject.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryProject.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        Repository<Book> BookRepository { get; }
        Repository<Author> AuthorRepository { get; }
        Repository<BookType> BookTypeRepository { get; }
        Repository<FeeStatus> FeeStatusRepository { get; }
        int Save();
    }
}
