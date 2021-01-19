using LibraryProject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryProject.Service
{
    public interface IAuthorService
    {
        IEnumerable<Author> GetAllAuthors();
        Author GetById(int id);
        
        Author AddAuthor(Author author);
        Author UpdateAuthor(Author author);
        bool DeleteAuthor(int authorId);


    }
}
