using LibraryProject.Model;
using LibraryProject.Persistence;
using LibraryProject.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryProject.Service
{
    public class BookTypeService : IBookTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        public BookTypeService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public BookType AddBookType(BookType booktype)
        {
            this._unitOfWork.BookTypeRepository.Add(booktype);
            this._unitOfWork.Save();

            return booktype;

        }

        public bool DeleteBookType(int booktypeId)
        {
            BookType booktype = this._unitOfWork.BookTypeRepository.GetById(booktypeId);
            if (booktype != null)
            {
                this._unitOfWork.BookTypeRepository.Remove(booktype);
                this._unitOfWork.Save();

                return true;
            }
            return false;
        }



        public IEnumerable<BookType> GetAllBookType()
        {
            return this._unitOfWork.BookTypeRepository.GetAll();
        }

        public BookType GetById(int id)
        {
            return this._unitOfWork.BookTypeRepository.GetById(id);
        }

        public BookType UpdateBookType(BookType booktype)
        {
            this._unitOfWork.BookTypeRepository.Update(booktype);
            this._unitOfWork.Save();

            return booktype;
        }
    }
}
