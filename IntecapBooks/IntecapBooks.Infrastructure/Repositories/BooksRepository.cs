using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IntecapBooks.Business.Entities;
using IntecapBooks.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace IntecapBooks.Infrastructure.Repositories
{
    public class BooksRepository : IRepository<Book>
    {
        ApplicationDbContext _context;
        public BooksRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Delete(int id)
        {
            var entity = _context.Books.FirstOrDefault(f => f.Id == id);
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public List<Book> Get()
        {
            return _context.Books.ToList();
        }

        public void Insert(Book newBook)
        {
            _context.Books.Add(newBook);
            _context.SaveChanges();
        }

        public void Update(int id, Book updateBook)
        {
            _context.Update(updateBook);
            _context.SaveChanges();
        }
    }
}
