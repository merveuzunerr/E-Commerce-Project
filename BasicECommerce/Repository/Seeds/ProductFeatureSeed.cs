using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Repository.Seeds
{
    public class ProductFeatureSeed : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasData(
                new ProductFeature() { Id=1, Description="Insta View", Color="Beyaz", ProductId=1 },
                new ProductFeature() { Id=2, Description="No Frost", Color="Gri", ProductId=2 },
                new ProductFeature() { Id=3, Description="No Frost", Color="Beyaz", ProductId=3 },
                new ProductFeature() { Id=4, Description="No Frost", Color="Gri", ProductId=4 },
                new ProductFeature() { Id=5, Description="i5 8/512 Gb", Color="Beyaz", ProductId=5 },
                new ProductFeature() { Id=6, Description="Matebook D15", Color="Siyah", ProductId=6 },
                new ProductFeature() { Id=7, Description="Macbook Air 13", Color="Beyaz", ProductId=7 },
                new ProductFeature() { Id=8, Description="Tuf Gaming", Color="Gri", ProductId=8 },
                new ProductFeature() { Id=9, Description="1.5 L", Color="Beyaz", ProductId=9 },
                new ProductFeature() { Id=10, Description="1700 Watt", Color="Beyaz", ProductId=10 },
                new ProductFeature() { Id=11, Description="Dijital", Color="Beyaz", ProductId=11 },
                new ProductFeature() { Id=12, Description="11 L", Color="Beyaz", ProductId=12 },
                new ProductFeature() { Id=13, Description="512 GB", Color="Beyaz", ProductId=13 },
                new ProductFeature() { Id=14, Description="128 GB", Color="Siyah", ProductId=14 },
                new ProductFeature() { Id=15, Description="128 GB", Color="Beyaz", ProductId=15 },
                new ProductFeature() { Id=16, Description="128 GB", Color="Mavi", ProductId=16 }
                );
        }
    }
}



