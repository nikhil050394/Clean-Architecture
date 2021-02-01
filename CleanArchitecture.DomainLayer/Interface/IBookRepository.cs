using CleanArchitecture.DomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.DomainLayer.Interface
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetBooks();

        int addBooks(Book newBook);
    }
}
