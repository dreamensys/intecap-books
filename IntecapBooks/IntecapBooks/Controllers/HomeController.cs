using IntecapBooks.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace IntecapBooks.Controllers
{
    public class HomeController : Controller
    {
        private IBooksService _bookService;
        public HomeController(IBooksService service)
        {
            _bookService = service;
        }

        public IActionResult Index()
        {
            var bookList = _bookService.GetBooks();
            return View(bookList);
        }

        //Home/Details/{id}
        public IActionResult Details(int id)
        {
            var bookList = _bookService.GetBooks();
            BookModel book = bookList.Where(item => item.Id == id).FirstOrDefault();
            return View(book);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
