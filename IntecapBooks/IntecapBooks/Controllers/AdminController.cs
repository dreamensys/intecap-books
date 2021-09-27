using IntecapBooks.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntecapBooks.Controllers
{
    public class AdminController : Controller
    {
        private IBooksService _bookService;

        public AdminController(IBooksService service)
        {
            _bookService = service;
        }

        //Admin/Books
        public IActionResult Books()
        {
            List<BookModel> bookList = _bookService.GetBooks();
            return View(bookList);
        }

        //Admin/Upsert
        public IActionResult UpsertBook(int? id)
        {
            NewBook newBookModel = new NewBook();
            newBookModel.CategoryList = GetCategories();
            newBookModel.CoverTypeList = GetCoverTypes();

            if (id != null) {
                List<BookModel> bookList = _bookService.GetBooks();
                BookModel book = bookList.Where(item => item.Id == id).FirstOrDefault();
                newBookModel.Book = book;
                return View(newBookModel);
            } 
            else
            {
                newBookModel.Book = new BookModel();

            }
            
            return View(newBookModel);
        }

        public IEnumerable<SelectListItem> GetCategories()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem() { Value = "1", Text = "Novela"},
                new SelectListItem() { Value = "2", Text = "SciFi"},
                new SelectListItem() { Value = "3", Text = "Científico"}
            };
        }

        public IEnumerable<SelectListItem> GetCoverTypes()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem() { Value = "1", Text = "Tapa Dura"},
                new SelectListItem() { Value = "2", Text = "Tapa Blanda"},
                new SelectListItem() { Value = "3", Text = "Digital"}
            };
        }

    }
}
