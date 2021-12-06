
using Microsoft.EntityFrameworkCore; 

namespace Shop.entities
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }
        public virtual DbSet<User> Users { get; set; } 
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; } 

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
                    Password="Letmein9x"
                }
            );
        }
    }
}
