using Books_shop.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Books_shop.Data
{
    public class AppDBContent :DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options) 
        { 
        
        }

        public DbSet<Book> Book { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ShopCartItem> ShopCartItem { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserType> UserType { get; set; }
        //public IEnumerable<object> User { get; internal set; }
    }
}

