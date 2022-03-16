using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using NLayer.Core;
using NLayer.Reppository.Configurations;

namespace NLayer.Reppository
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // bütün configurasyon classlarını çalıştır.
                                                                                            //productconfigurationu çalıştır.
            base.OnModelCreating(modelBuilder);
        }



        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }


    }
}
