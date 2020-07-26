using DAL.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Context
{
    
    public class AppDbContext : IdentityDbContext<AppUser, AppUserRole, Guid>
    {
     //!!Options kısmının mavi olmaması problem çıkarabilir!!
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Myproperty { get; set; }
        public DbSet<OrderDetail> Orderdetails { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
