using CleanArchitecture.DomainLayer.Interface;
using CleanArchitecture.DomainLayer.Model;
using CleanArchitecture.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Infra.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        public LibraryDbContext _context;
        public BookRepository(LibraryDbContext context)
        {
            _context = context;
        }

        public int addBooks(Book NewBook)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetBooks()
        {
            return _context.Books;
        }
    }
}