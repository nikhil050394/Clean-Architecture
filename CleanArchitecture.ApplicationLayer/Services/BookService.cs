using CleanArchitecture.ApplicationLayer.Interface;
using CleanArchitecture.ApplicationLayer.ViewModels;
using CleanArchitecture.DomainLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.ApplicationLayer.Services
{
   public class BookService : IBookService
    {
        public IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public BookViewModel GetBooks()
        {
            return new BookViewModel()
            {
                Books = _bookRepository.GetBooks()
            };
        }
    }
}
