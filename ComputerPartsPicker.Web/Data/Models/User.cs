using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ComputerPartsPicker.Web.Data.Models
{
    public class User : IdentityUser
    {
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
