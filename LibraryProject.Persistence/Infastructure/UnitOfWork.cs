using LibraryProject.Model;
using LibraryProject.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryProject.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BookContext _context;
        public Repository<Book> BookRepository { get; }
        public Repository<Author> AuthorRepository { get; }
        public Repository<BookType> BookTypeRepository { get; }
        public Repository<FeeStatus> FeeStatusRepository { get; }

        public UnitOfWork(BookContext context)
        {
            this._context = context;
            this.BookRepository = new Repository<Book>(this._context);
            this.AuthorRepository = new Repository<Author>(this._context);
            this.BookTypeRepository = new Repository<BookType>(this._context);
            this.FeeStatusRepository = new Repository<FeeStatus>(this._context);
           
        }
        public int Save()
        {
            return this._context.SaveChanges();
        }
        public void Dispose()
        {
            this._context.Dispose();
        }


    }

}
