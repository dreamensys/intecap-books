using IntecapBooks.Models;
using System.Collections.Generic;

namespace IntecapBooks
{
    public interface IBooksService
    {
        List<BookModel> GetBooks();
    }
}
