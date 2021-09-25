using System;
using System.Collections.Generic;

namespace IntecapBooks.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }

        public string Author { get; set; }

        public double Price { get; set; }

        public double Discount { get; set; }
        public string ImageUrl { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public int CoverTypeId { get; set; }
        public CoverType CoverType { get; set; }

        public string GetSummary() {
            string summary;
            summary = Id + "-" +Title+ "-"+ISBN;
            return summary;
        }

        public double GetPrice(bool includeDiscount) {
            double price = Price;
            double taxes = 0;
            if (includeDiscount == true) {
                taxes = 0.4;
                double deductions = GetDeductions(price);
                price = price - deductions;
            }

            return price + taxes;
        }

        private double GetDeductions(double price) {
            string extraDiscount = "0.08";
            double rappiDiscount = double.Parse(extraDiscount);
            return price * Discount * rappiDiscount;
        }

    }
}
