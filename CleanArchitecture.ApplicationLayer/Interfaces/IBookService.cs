using CleanArchitecture.ApplicationLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.ApplicationLayer.Interface
{
    public interface IBookService
    {        
        BookViewModel GetBooks();
    }
}