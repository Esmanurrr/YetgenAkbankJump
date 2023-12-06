using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YetgenAkbankJump.Domain.Entities;

namespace YetgenAkbankJump.Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            //ID - Primary Key
            builder.HasKey(x => x.Id); // best practice
            builder.Property(x => x.Id).ValueGeneratedOnAdd(); // to increase one by one Id value

            //FirstName
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(60);

            // Common Fields

            // CreatedByUserId
            builder.Property(x => x.CreatedByUserId).IsRequired();
            builder.Property(x => x.CreatedByUserId).HasMaxLength(75);

            // CreatedOn
            builder.Property(x => x.CreatedOn).IsRequired();

            // ModifiedByUserId
            builder.Property(x => x.ModifiedByUserId).IsRequired(false);
            builder.Property(x => x.ModifiedByUserId).HasMaxLength(75);

            // LastModifiedOn
            builder.Property(x => x.LastModifiedOn).IsRequired(false);

            // DeletedByUserId
            builder.Property(x => x.DeletedByUserId).IsRequired(false);
            builder.Property(x => x.DeletedByUserId).HasMaxLength(75);

            // DeletedOn
            builder.Property(x => x.DeletedOn).IsRequired(false);

            // IsDeleted
            builder.Property(x => x.IsDeleted).IsRequired();

            //Relationships
            //builder.HasOne<Category>(x => x.Category) // Product has one category 
            //    .WithMany(x => x.Products) // each cateogry with many products
            //    .HasForeignKey(x => x.CategoryId); 

            builder.ToTable("Products");
        }
    }
}
