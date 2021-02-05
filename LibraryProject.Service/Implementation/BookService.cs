using AutoMapper;
using LibraryProject.Model;
using LibraryProject.Persistence;
using LibraryProject.Service;
using LibraryProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryProject.Service
{
    public class BookService :IBookService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;
        public BookService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }
        public IEnumerable<BookViewModel> GetAllBook()
        {
            var booklist = this._unitOfWork.BookRepository.GetAll();

            var BookViewModelList = _mapper.Map<IEnumerable<BookViewModel>>(booklist);

            return BookViewModelList;

        }
        public Book GetById(int id)
        {
            return this._unitOfWork.BookRepository.GetById(id);
        }
        public Book UpdateBook(Book book)
        {
            this._unitOfWork.BookRepository.Update(book);
            this._unitOfWork.Save();

            return book;
        }

        public bool DeleteBook(int bookId)
        {
            Book book = this._unitOfWork.BookRepository.GetById(bookId);
            if (book != null)
            {
                this._unitOfWork.BookRepository.Remove(book);
                this._unitOfWork.Save();

                return true;
            }
            return false;
        }

        public BookViewModel AddBook(BookViewModel book)
        {
            Book newBook = this._mapper.Map<Book>(book);
            this._unitOfWork.BookRepository.Add(newBook);
            this._unitOfWork.Save();
            return this._mapper.Map<BookViewModel>(newBook);
        }

    }
}

