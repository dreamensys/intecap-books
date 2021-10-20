using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace IntecapBooks.Business.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        [NotMapped]
        public string Password { get; set; }

        public string StreetAddress { get; set; }
        public string City { get; set; }
    }
}
