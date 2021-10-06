using IntecapBooks.Data;
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
        ApplicationDbContext _context = new ApplicationDbContext();

        public AdminController(IBooksService service)
        {
            _bookService = service;
        }

        //Admin/Books
        public IActionResult Books()
        {
            var categories = _context.Categories; // = SELECT * FROM Categories;
            var books = _context.Books; // SELECT * FROM Books;
            List<BookModel> bookList = books.ToList();//_bookService.GetBooks();
            return View(bookList);
        }

        //GET: Admin/Upsert
        public IActionResult UpsertBook(int? id)
        {
            NewBook newBookModel = new NewBook();
            newBookModel.CategoryList = GetCategories();
            newBookModel.CoverTypeList = GetCoverTypes();

            if (id != null) {
                List<BookModel> bookList = _context.Books.ToList();
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

        // POST:/Admin/Upsert
        [HttpPost]
        public IActionResult UpsertBook(NewBook bookFormData)
        {
            if (ModelState.IsValid)
            {
                if (bookFormData.Book.Id != 0)
                {
                    BookModel existingBook = _context.Books.FirstOrDefault(f => f.Id == bookFormData.Book.Id);
                    existingBook.Author = bookFormData.Book.Author;
                    existingBook.CategoryId = bookFormData.Book.CategoryId;
                    existingBook.CoverTypeId = bookFormData.Book.CoverTypeId;
                    existingBook.Description = bookFormData.Book.Description;
                    existingBook.Discount = bookFormData.Book.Discount;
                    existingBook.Title = bookFormData.Book.Title;
                    existingBook.ImageUrl = bookFormData.Book.ImageUrl;
                    existingBook.ISBN = bookFormData.Book.ISBN;
                    existingBook.Price = bookFormData.Book.Price;

                    _context.Update(existingBook);
                    _context.SaveChanges();
                }
                else
                {
                    BookModel newBook = new BookModel();
                    newBook = bookFormData.Book;
                    _context.Books.Add(newBook);
                    _context.SaveChanges();
                }
                return RedirectToAction(nameof(Books));
            }
            else {
                bookFormData.CategoryList = GetCategories();
                bookFormData.CoverTypeList = GetCoverTypes();
                
                if (bookFormData.Book.Id != 0)
                {
                    bookFormData.Book = _context.Books.FirstOrDefault(f => f.Id == bookFormData.Book.Id);
                }
            }

            return View(bookFormData);
            
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
