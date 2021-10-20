using IntecapBooks.Infrastructure.API.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IntecapBooks.Infrastructure.API
{
    public interface IExternalBookProviderClient
    {
        Task<List<ExternalBook>> GetBooks();
    }
}
