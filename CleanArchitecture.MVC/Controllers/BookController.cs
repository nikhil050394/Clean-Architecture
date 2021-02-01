using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.ApplicationLayer.Interface;
using Microsoft.AspNetCore.Mvc;
using CleanArchitecture.ApplicationLayer.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace CleanArchitecture.MVC.Controllers
{
    
    public class BookController : Controller
    {
        private IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [Authorize]
        public IActionResult Index()
        {
            BookViewModel model = _bookService.GetBooks();
            return View(model);
        }
       
    }
}