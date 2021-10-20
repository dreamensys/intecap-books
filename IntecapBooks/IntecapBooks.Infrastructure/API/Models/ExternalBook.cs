using System;
using System.Collections.Generic;
using System.Text;

namespace IntecapBooks.Infrastructure.API.Models
{
    public class ExternalBook
    {
        public int BookId { get; set; }

        public string BookTitle { get; set; }

        public string BookDescription { get; set; }

        public string ISBN { get; set; }

        public string BookAuthor { get; set; }

        public double Price { get; set; }

        public double Discount { get; set; }
    }
}
