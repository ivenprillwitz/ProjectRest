using ProjectRest.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectRest.Services
{   
    public class DirectoryService : IDirectoryService
    {
        private ProjectRestContext _context;

        public DirectoryService(ProjectRestContext context)
        {
            _context = context;
        }

        public bool AuthorExists(Guid authorId)
        {
            return _context.Author.Any(a => a.Id == authorId);
        }

        public Author GetAuthor(Guid authorId)
        {
            return _context.Author.FirstOrDefault(a => a.Id == authorId);
        }

        public IEnumerable<Author> GetAuthors()
        {
            return _context.Author.OrderBy(a => a.FirstName).ThenBy(a => a.LastName);
        }

        public Book GetBookByAuthor(Guid authorId, Guid bookId)
        {
            return _context.Book
              .Where(b => b.AuthorId == authorId && b.Id == bookId).FirstOrDefault();
        }

        public IEnumerable<Book> GetBooksByAuthorId(Guid authorId)
        {
            return _context.Book
                        .Where(b => b.AuthorId == authorId).OrderBy(b => b.Title).ToList();
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
