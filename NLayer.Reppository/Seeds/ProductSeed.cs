using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;

namespace NLayer.Reppository.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
                Id = 1,
                CategoryId = 1,
                Name= "Kalem 1",
                Price = 100,
                Stock = 15,
                CreateDate = DateTime.Now
            },
           new Product {
                Id = 2,
                CategoryId = 1,
                Name = "Kalem 2",
                Price = 300,
                Stock = 15,
                CreateDate = DateTime.Now
            },
           new Product {
                Id = 3,
                CategoryId = 1,
                Name = "Kalem 3",
                Price = 200,
                Stock = 15,
                CreateDate = DateTime.Now
            },
              new Product
              {
                  Id = 4,
                  CategoryId = 2,
                  Name = "Kitaplar 1",
                  Price = 200,
                  Stock = 15,
                  CreateDate = DateTime.Now
              },
                 new Product
                 {
                     Id = 5,
                     CategoryId = 2,
                     Name = "Kalem 2",
                     Price = 100,
                     Stock = 15,
                     CreateDate = DateTime.Now
                 }

            );
        }
    }
}
