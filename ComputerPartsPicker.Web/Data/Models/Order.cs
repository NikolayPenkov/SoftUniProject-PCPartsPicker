using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComputerPartsPicker.Web.Data.Models
{
    public class Order
    {
        [Key]
        public string Id { get; set; }
     
        [ForeignKey(nameof(Product.Id))]
        public int ProductId { get; set; }

        public Product product {  get; set; } 
        public int UserId { get; set; }
        [ForeignKey(nameof(Models.User.Id))]
         public User User { get; set; } 
       
        public decimal OrderPrice { get; set; }

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
