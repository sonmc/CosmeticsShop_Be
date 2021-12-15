
using Microsoft.EntityFrameworkCore;
using Shop.constant;
using System.Collections.Generic;

namespace Shop.entities
{
    public class DataContext : DbContext
    {
        public DataContext() { }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Composition> Compositions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    UserName = "Admin",
                    Password = "Letmein9x",
                    Email = "admin@gmail.com",
                    Age = 30,
                    Role = 1,
                    Address = "Hà nội",
                }
            );
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = (int)Configs.ID_CATEGORY_DEFAULT,
                    Name = "CATEGORY DEFAULT",
                    Description = "This is the category default use for create products",
                    Products = new List<Product>()
                }
            );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = (int)Configs.ID_PRODUCT_DEFAULT,
                    Compositions = new List<Composition>(),
                    CreatedDate = null,
                    Description = "This is the product default use for create composition",
                    Evaluate = 0,
                    CategoryId = (int)Configs.ID_CATEGORY_DEFAULT,
                    IdCode = "",
                    Images = "",
                    Link = "",
                    ListedPrice = null,
                    ModifiedDate = null,
                    NameCategory = "",
                    NameProduct = "This is the product default", 
                    TotalItems = 0,
                }
            );
        }
    }
}