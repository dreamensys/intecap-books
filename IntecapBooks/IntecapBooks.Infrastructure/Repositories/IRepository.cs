using IntecapBooks.Business.Entities;
using System.Collections.Generic;

namespace IntecapBooks.Infrastructure.Repositories
{
    public interface IRepository<T>
    {
        List<T> Get();

        void Insert(T newEntity);
        void Update(int id, T updateEntity);

        void Delete(int id);
    }
}
