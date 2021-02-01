using CleanArchitecture.DomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.ApplicationLayer.ViewModels
{


    public class BookViewModel
    {
        public IEnumerable<Book> Books { get; set; }
    }

}
