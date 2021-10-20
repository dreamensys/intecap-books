using IntecapBooks.Business.Entities;
using IntecapBooks.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntecapBooks.Infrastructure.Repositories
{
    public class CoverTypesRepository : IRepository<CoverType>
    {
        ApplicationDbContext _context = new ApplicationDbContext();

        public void Delete(int id)
        {
            var entity = _context.CoverTypes.FirstOrDefault(f => f.Id == id);
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public List<CoverType> Get()
        {
            return _context.CoverTypes.ToList();
        }

        public void Insert(CoverType newCoverType)
        {
            _context.CoverTypes.Add(newCoverType);
            _context.SaveChanges();
        }

        public void Update(int id, CoverType updateCoverType)
        {
            _context.Update(updateCoverType);
            _context.SaveChanges();
        }
    }
}
