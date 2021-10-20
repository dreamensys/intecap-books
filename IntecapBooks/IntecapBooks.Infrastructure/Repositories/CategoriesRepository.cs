using IntecapBooks.Business.Entities;
using IntecapBooks.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntecapBooks.Infrastructure.Repositories
{
    public class CategoriesRepository : IRepository<Category>
    {
        ApplicationDbContext _context = new ApplicationDbContext();

        public void Delete(int id)
        {
            var entity = _context.Categories.FirstOrDefault(f => f.Id == id);
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public List<Category> Get()
        {
            return _context.Categories.ToList();
        }

        public void Insert(Category newCategory)
        {
            _context.Categories.Add(newCategory);
            _context.SaveChanges();
        }

        public void Update(int id, Category updateCategory)
        {
            _context.Update(updateCategory);
            _context.SaveChanges();
        }
    }
}
