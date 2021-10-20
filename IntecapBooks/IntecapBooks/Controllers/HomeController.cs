
using IntecapBooks.Infrastructure.API;
using IntecapBooks.Infrastructure.API.Models;
using IntecapBooks.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IntecapBooks.Controllers
{
    public class HomeController : Controller
    {
        private IBooksService _bookService;
        private IExternalBookProviderClient _externalBookProvider;
        public HomeController(IBooksService service, IExternalBookProviderClient externalProvider)
        {
            _bookService = service;
            _externalBookProvider = externalProvider;
        }

        public async Task<IActionResult> Index()
        {
            var externalBooks = await _externalBookProvider.GetBooks();
            var bookList = _bookService.GetBooks();
            foreach (ExternalBook externalBook in externalBooks)
            {
                BookModel book = new BookModel();
                book.Id = externalBook.BookId;
                book.ISBN = externalBook.ISBN;
                book.Price = externalBook.Price;
                book.Title = externalBook.BookTitle;
                book.Author = externalBook.BookAuthor;
                bookList.Add(book);
            }
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
