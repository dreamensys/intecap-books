using IntecapBooks.Infrastructure.API.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IntecapBooks.Infrastructure.API
{
    public class ExternalBookProviderClient : IExternalBookProviderClient
    {
        private HttpClient _apiClient;
        public ExternalBookProviderClient(HttpClient client)
        {
            _apiClient = client;
        }
        public async Task<List<ExternalBook>> GetBooks()
        {
            var externalBooks = new List<ExternalBook>();
            try
            {
                string uri = "http://localhost:1270/api/books";
                var response = await _apiClient.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    externalBooks = JsonConvert.DeserializeObject<List<ExternalBook>>(result);
                }
            }
            catch (Exception)
            {

                
            }
            
            
            return externalBooks;
            
        }
    }
}
