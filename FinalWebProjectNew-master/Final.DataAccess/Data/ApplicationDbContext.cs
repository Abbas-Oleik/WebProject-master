using Final.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Final.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = 1,
                    Name = "Tech Solution",
                    StreetAddress = "123 Tech St",
                    City = "Tech City",
                    PostalCode = "12121",
                    State = "IL",
                    PhoneNumber = "6669990000"
                },
                new Company
                {
                    Id = 2,
                    Name = "Vivid Books",
                    StreetAddress = "999 Vid St",
                    City = "Vid City",
                    PostalCode = "66666",
                    State = "IL",
                    PhoneNumber = "7779990000"
                },
                new Company
                {
                    Id = 3,
                    Name = "Readers Club",
                    StreetAddress = "999 Main St",
                    City = "Lala land",
                    PostalCode = "99999",
                    State = "NY",
                    PhoneNumber = "1113335555"
                }
                );


            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Fortune of Time",
                    Author = "Billy Spark",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ISBN = "SWD9999001",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Title = "Dark Skies",
                    Author = "Nancy Hoover",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ISBN = "CAW777777701",
                    ListPrice = 40,
                    Price = 30,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 3,
                    Title = "Vanish in the Sunset",
                    Author = "Julian Button",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ISBN = "RITO5555501",
                    ListPrice = 55,
                    Price = 50,
                    Price50 = 40,
                    Price100 = 35,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 4,
                    Title = "Cotton Candy",
                    Author = "Abby Muscles",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ISBN = "WS3333333301",
                    ListPrice = 70,
                    Price = 65,
                    Price50 = 60,
                    Price100 = 55,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 5,
                    Title = "Rock in the Ocean",
                    Author = "Ron Parker",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ISBN = "SOTJ1111111101",
                    ListPrice = 30,
                    Price = 27,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 6,
                    Title = "Leaves and Wonders",
                    Author = "Laura Phantom",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ISBN = "FOT000000001",
                    ListPrice = 25,
                    Price = 23,
                    Price50 = 22,
                    Price100 = 20,
                    CategoryId = 3
                }
                );
            modelBuilder.Entity<ProductImage>().HasData(
                new ProductImage
                {
                    Id = 1,
                    ImageUrl = "/images/products/product-1/0f09982d-d0b7-4571-9ada-1267ad925470.jpg",
                    ProductId = 1
                }, new ProductImage
                {
                    Id = 2,
                    ImageUrl = "/images/products/product-1/3cc41d0b-70cc-4203-a5e2-ff90aa05fc79.jpg",
                    ProductId = 1
                }, new ProductImage
                {
                    Id = 3,
                    ImageUrl = "/images/products/product-2/35a155bd-4d84-4926-936b-bc1c0cff2017.jpg",
                    ProductId = 2
                }, new ProductImage
                {
                    Id = 4,
                    ImageUrl = "/images/products/product-2/6c2133da-211f-4ef1-90a9-dd1cf3b66f38.jpg",
                    ProductId = 2
                },
                   new ProductImage
                   {
                       Id = 5,
                       ImageUrl = "/images/products/product-3/1f36fa1f-7f9a-4b4f-84d2-eafbf69a6220.jpg",
                       ProductId = 3
                   },
                new ProductImage
                {
                    Id = 6,
                    ImageUrl = "/images/products/product-3/748b27d9-9802-42f6-adab-8df55aaf4342.jpg",
                    ProductId = 3
                },
                new ProductImage
                {
                    Id = 7,
                    ImageUrl = "/images/products/product-4/8be61614-113a-4dd5-a2ff-d1eb70e16f0b.jpg",
                    ProductId = 4
                },
                new ProductImage
                {
                    Id = 8,
                    ImageUrl = "/images/products/product-4/6b702e26-aa2b-47b1-bab3-f885486939e3.jpg",
                    ProductId = 4
                },
                new ProductImage
                {
                    Id = 9,
                    ImageUrl = "/images/products/product-5/1cbca164-761a-4c55-9459-82d6f2c9e0c1.jpg",
                    ProductId = 5
                },
                new ProductImage
                {
                    Id = 10,
                    ImageUrl = "/images/products/product-5/7f0d6e2a-1a34-4c44-9596-0893338718bf.jpg",
                    ProductId = 5
                },
                new ProductImage
                {
                    Id = 11,
                    ImageUrl = "/images/products/product-6/3772c79c-f3dd-4f33-ba5a-e4bb6e198375.jpg",
                    ProductId = 6
                },
                new ProductImage
                {
                    Id = 12,
                    ImageUrl = "/images/products/product-6/52814dff-4844-44a5-8e73-95b0e9c22c50.jpg",
                    ProductId = 6
                }

                            );



        }
    }
}
