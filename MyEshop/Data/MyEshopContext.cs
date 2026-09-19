using Microsoft.EntityFrameworkCore;
using MyEshop.Models;

namespace MyEshop.Data
{
    public class MyEshopContext : DbContext
    {
        public MyEshopContext(DbContextOptions<MyEshopContext> options):  base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Seed Data Category

            modelBuilder.Entity<Category>().HasData(new Category()
            {
                Id = 1,
                Name = "Asp.Net Core",
                Description = "Asp.Net Core 9"

            },
            new Category()
            {
                Id = 2,
                Name = "لباس ورزشی ",
                Description = "گروه لباس ورزشی"

            },
            new Category()
            {
                Id = 3,
                Name = "ساعت مچی",
                Description = "ساعت مچی"

            },
            new Category()
            {
                Id = 4,
                Name = "لوازم منزل",
                Description = "لوازم منزل"

            }
                );

            #endregion
           base.OnModelCreating(modelBuilder);
        }
    }
}
