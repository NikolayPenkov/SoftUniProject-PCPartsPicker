using System.ComponentModel.DataAnnotations;
using static Constants.AplicationConstants.ProductConstants;
namespace ComputerPartsPicker.Web.Data.Models
{
    public class Product
    {
       
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(ProductBrandMaxLength)]
        public string Brand { get; set; } = null!;
        [Required]
        [MaxLength(ProductNameMaxLength)]
        public string Name { get; set; } = null!;
        [Required]
        [MaxLength(ProductDescriptionMinLength)]
        public string Description { get; set; } = null!;
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string ImageUrl { get; set; } = null!;
        [Required]
        public Category Category { get; set; } = null!;
    }
}
