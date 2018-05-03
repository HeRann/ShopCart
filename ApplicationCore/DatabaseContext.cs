using DomainModels.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace ApplicationCore
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("connstring")
        {
        }
        //DBSet for all the tables
        public DbSet<Order> Orders { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<User> Users { get; set; }

        ////Using FluentAPI to define M2M replation ship of Role and User -Way (1)
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Entity<User>().HasMany(u => u.Roles).WithMany(m => m.Users).
                 Map(r =>
                 {
                     r.MapLeftKey("UserId");
                     r.MapRightKey("RoleId");
                     r.ToTable("UserRole");
                 });
        }
        //Using FluentAPI to define M2M replation ship of Role and User -Way (2)
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Role>().HasMany(r => r.Users).WithMany(u => u.Roles).
        //        Map(m =>
        //        {
        //            m.MapLeftKey("RoleId");
        //            m.MapRightKey("UserId");
        //            m.ToTable("UserRole");
        //        });

        //}
    }
}
