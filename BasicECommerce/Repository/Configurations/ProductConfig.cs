using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Repository.Configurations
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Stock).IsRequired();
            builder.Property(x => x.Price).IsRequired();

            builder.ToTable("Products");

            builder.HasOne(x => x.SubCategory).WithMany(x => x.Products).HasForeignKey(x=>x.SubCategoryId);
            builder.HasMany(x => x.Carts).WithMany(x => x.Products);
            
        }
    }
}
