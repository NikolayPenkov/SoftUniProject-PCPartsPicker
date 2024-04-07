using ComputerPartsPicker.Web.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ComputerPartsPicker.Web.Data
{
    public class ComputerPartsPickerDbContext : IdentityDbContext<User>
    {
        public ComputerPartsPickerDbContext(DbContextOptions<ComputerPartsPickerDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; } = null!;
     
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Order>()
                .HasKey(x => new { x.UserId, x.ProductId });

        
                   
              
                
                

            builder.Entity<User>()
                  .Property(u => u.UserName)
                  .HasMaxLength(20)
                  .IsRequired();

            builder.Entity<User>()
              .Property(u => u.Email)
              .HasMaxLength(60)
              .IsRequired();





            builder
                 .Entity<Category>()
                 .HasData(new Category()
                 {
                     Id = 1,
                     Name = "CPU",
                 },
                 new Category()
                 {
                     Id = 2,
                     Name = "GPU",
                 },
                  new Category()
                  {
                      Id = 3,
                      Name = "RAM",
                  },
                  new Category()
                  {
                      Id = 4,
                      Name = "Motherboard"
                  },
                   new Category()
                   {
                       Id = 5,
                       Name = "PSU"
                   },
                    new Category()
                    {
                        Id = 6,
                        Name = "Case"
                    },
                     new Category()
                     {
                         Id = 7,
                         Name = "Storage"
                     },
                     new Category()
                     {
                         Id = 8,
                         Name = "Cooler"
                     });

            base.OnModelCreating(builder);
        }

    }
}



   
   