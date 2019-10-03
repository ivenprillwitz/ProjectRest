using ProjectRest.Models;
using System;
using System.Collections.Generic;

namespace ProjectRest.Services
{
    public interface IDirectoryService
    {
        IEnumerable<Author> GetAuthors();
        Author GetAuthor(Guid authorId);
        bool AuthorExists(Guid authorId);
        IEnumerable<Book> GetBooksByAuthorId(Guid authorId);
        Book GetBookByAuthor(Guid authorId, Guid bookId);
        bool Save();
    }
}
