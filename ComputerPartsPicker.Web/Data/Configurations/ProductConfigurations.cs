using ComputerPartsPicker.Web.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace ComputerPartsPicker.Web.Data.Configurations
{
    public class ProductConfigurations
    {
        private Product[] GenerateProducts()
        {
            ICollection<Product> products = new List<Product>();

            Product product;

            product = new Product()
            {
                Id = 1,
                Brand = "AMD",

                Name = "Ryzen 5 2600",

                Description = "# of Cores - 6 \r\n# of Threads - 12\r\nCPU Socket Type - AM4\r\nBase Clock - 3400 MHz\r\nTurbo Clock - 3900 MHz\r\nTDP - 65W\r\nLaunch Date - 04/19/2018",

                Price = 140,
                ImageUrl = "https://www.techspot.com/articles-info/1614/images/Image_03.jpg",
              //  Category 
                
            };
        }
    }
}


      