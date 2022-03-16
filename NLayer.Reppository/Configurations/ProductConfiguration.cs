using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;

namespace NLayer.Reppository.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x=>x.Name).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Stock).IsRequired();
            //builder.Property(x => x.Price).IsRequired().HasColumnType(¨decimal(18,2)¨); 16,2
            //builder=product == productın bir tane categorysiolabilir fakat categoryinin birden fazla productı olabilir, ürünün foreignkey ise categoryId'dir.
            builder.HasOne(x => x.category).WithMany(x => x.Product).HasForeignKey(x=>x.CategoryId);

        }
    }
}
