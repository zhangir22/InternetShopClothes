using InternetShopClothes.Infrastructure.Models.Cloth;
using InternetShopClothes.Infrastructure.Models.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShopClothes.Infrastructure
{
    public class InternetShopClothDbContext : DbContext
    { 
        public InternetShopClothDbContext() { }
        public InternetShopClothDbContext(DbContextOptions<InternetShopClothDbContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer();
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
             
            builder.Entity<ClothModel>().HasKey(c=> c.Id);  
            builder.Entity<UserModel>().HasKey(c=> c.Id);

            base.OnModelCreating(builder);
        }
        public DbSet<ClothModel> Cloths { get; set; }
        public DbSet<UserModel> Users { get; set; }
    }
}
