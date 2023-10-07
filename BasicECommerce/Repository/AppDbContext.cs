using Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            //var p=new Product() { ProductFeature=new ProductFeature() { } }
        }

        public DbSet<ParentCategory> ParentCategories { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeature { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }
        //public DbSet<GuestAccount> GuestAccounts { get; set; }
        //public DbSet<Session> Sessions { get; set; }
        public DbSet<Cart> Carts { get; set; }
       
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserAccount>().Property(x => x.IsActive).HasDefaultValue(true);
            modelBuilder.Entity<Cart>().Property(x => x.IsActive).HasDefaultValue(true);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
