using System.ComponentModel.DataAnnotations;

namespace ComputerPartsPicker.Web.Data.Models
{
    public class Category
    {
       [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength()]
        public string Name { get; set; } = string.Empty!;
      
    }
}
