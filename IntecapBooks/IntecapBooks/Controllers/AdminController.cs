using IntecapBooks.Business.Entities;
using IntecapBooks.Infrastructure.Repositories;
using IntecapBooks.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntecapBooks.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        private IBooksService _bookService;
        IRepository<Book> _booksRepository;
        CategoriesRepository _categoriesRepository = new CategoriesRepository();
        CoverTypesRepository _coverTypesRepository = new CoverTypesRepository();

        public AdminController(IBooksService service, IRepository<Book> booksRepository)
        {
            _bookService = service;
            _booksRepository = booksRepository;
        }

        //Admin/Books
        public IActionResult Books()
        {
            var books = _booksRepository.Get();
            List<BookModel> bookList = new List<BookModel>();
            foreach (var book in books)
            {
                var tmpBook = new BookModel();
                tmpBook.Id = book.Id;
                tmpBook.Author = book.Author;
                tmpBook.Description = book.Description;
                bookList.Add(tmpBook);
            }
            return View(bookList);
        }

        //GET: Admin/Upsert
        public IActionResult UpsertBook(int? id)
        {
            NewBook newBookModel = new NewBook();
            newBookModel.CategoryList = GetCategories();
            newBookModel.CoverTypeList = GetCoverTypes();

            if (id != null) {
                Book foundBook= _booksRepository.Get().FirstOrDefault(f => f.Id == id);

                BookModel book = new BookModel();
                book.Id = foundBook.Id;
                book.Description = foundBook.Description;
                newBookModel.Book = book;
                return View(newBookModel);
            } 
            else
            {
                newBookModel.Book = new BookModel();

            }
            
            return Ok(newBookModel);
        }

        // POST:/Admin/Upsert
        [HttpPost]
        public IActionResult UpsertBook([FromBody] NewBook bookFormData)
        {
            if (ModelState.IsValid)
            {
                if (bookFormData.Book.Id != 0)
                {
                    Book existingBook = _booksRepository.Get().FirstOrDefault(f => f.Id == bookFormData.Book.Id);
                    existingBook.Author = bookFormData.Book.Author;
                    existingBook.CategoryId = bookFormData.Book.CategoryId;
                    existingBook.CoverTypeId = bookFormData.Book.CoverTypeId;
                    existingBook.Description = bookFormData.Book.Description;
                    existingBook.Discount = bookFormData.Book.Discount;
                    existingBook.Title = bookFormData.Book.Title;
                    existingBook.ImageUrl = bookFormData.Book.ImageUrl;
                    existingBook.ISBN = bookFormData.Book.ISBN;
                    existingBook.Price = bookFormData.Book.Price;

                    _booksRepository.Update(bookFormData.Book.Id, existingBook);
                    
                }
                else
                {
                    Book newBook = new Book();
                    newBook.Author = bookFormData.Book.Author;
                    newBook.CategoryId = bookFormData.Book.CategoryId;
                    newBook.CoverTypeId = bookFormData.Book.CoverTypeId;
                    newBook.Description = bookFormData.Book.Description;
                    newBook.Discount = bookFormData.Book.Discount;
                    newBook.Title = bookFormData.Book.Title;
                    newBook.ImageUrl = bookFormData.Book.ImageUrl;
                    newBook.ISBN = bookFormData.Book.ISBN;
                    newBook.Price = bookFormData.Book.Price;
                    _booksRepository.Insert(newBook);
                }
                return RedirectToAction(nameof(Books));
            }
            else {
                bookFormData.CategoryList = GetCategories();
                bookFormData.CoverTypeList = GetCoverTypes();
                
                if (bookFormData.Book.Id != 0)
                {
                    bookFormData.Book = new BookModel(); //_context.Books.FirstOrDefault(f => f.Id == bookFormData.Book.Id);
                }
            }

            return View(bookFormData);
            
        }

        public IEnumerable<SelectListItem> GetCategories()
        {
           return _categoriesRepository.Get().Select(s => new SelectListItem() { Value = s.Id.ToString(), Text = s.Name}).ToList();
        }

        public IEnumerable<SelectListItem> GetCoverTypes()
        {
            return _coverTypesRepository.Get().Select(s => new SelectListItem() { Value = s.Id.ToString(), Text = s.Name }).ToList();
        }

    }
}
