using LibraryProject.Model;
using LibraryProject.Persistence;
using LibraryProject.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryProject.Service
{
    public class AuthorService : IAuthorService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AuthorService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public Author AddAuthor(Author author)
        {
            this._unitOfWork.AuthorRepository.Add(author);
            this._unitOfWork.Save();

            return author;
        }

        public bool DeleteAuthor(int authorId)
        {
            Author author = this._unitOfWork.AuthorRepository.GetById(authorId);
            if (author != null)
            {
                this._unitOfWork.AuthorRepository.Remove(author);
                this._unitOfWork.Save();

                return true;
            }
            return false;
        }

        public IEnumerable<Author> GetAllAuthors()
        {
            return this._unitOfWork.AuthorRepository.GetAll();
        }

        public Author GetById(int id)
        {
            return this._unitOfWork.AuthorRepository.GetById(id);
        }

        public Author UpdateAuthor(Author author)
        {

            this._unitOfWork.AuthorRepository.Update(author);
            this._unitOfWork.Save();

            return author;
        }
    }
 }

