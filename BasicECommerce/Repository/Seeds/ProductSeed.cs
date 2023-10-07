using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
               new Product() { Id=1, Name="LG BUZDOLABI", Stock=100, Price=138999, SubCategoryId=1},
                 new Product() { Id=2, Name="VESTEL BUZDOLABI", Stock=80, Price=16425, SubCategoryId=1},
                   new Product() { Id=3, Name="SIEMENS BUZDOLABI", Stock=70, Price=37959, SubCategoryId=1},
                     new Product() { Id=4, Name="SAMSUNG BUZDOLABI", Stock=50, Price=37989, SubCategoryId=1},
               new Product() { Id=5, Name="LENOVA LEPTOP", Stock=100, Price=13899, SubCategoryId=2 },
                 new Product() { Id=6, Name="HUAWEİ LEPTOP", Stock=80, Price=14425, SubCategoryId=2},
                   new Product() { Id=7, Name="APPLE LEPTOP", Stock=70, Price=38959, SubCategoryId=2},
                     new Product() { Id=8, Name="ASUS LEPTOP", Stock=50, Price=24000, SubCategoryId=2},
               new Product() { Id=9, Name="VESTEL KETTLE", Stock=100, Price=1400, SubCategoryId=3},
                 new Product() { Id=10, Name="ARZUM BLENDER", Stock=80, Price=1000, SubCategoryId=4},
                   new Product() { Id=11, Name="SINBO TARTI", Stock=70, Price=250, SubCategoryId=5},
                     new Product() { Id=12, Name="KIWI AIRFRYER", Stock=50, Price=4500, SubCategoryId=6},
               new Product() { Id=13, Name="IPHONE 15", Stock=100, Price=55000, SubCategoryId=7},
                 new Product() { Id=14, Name="IPHONE 14 ", Stock=80, Price=42000, SubCategoryId=7},
                   new Product() { Id=15, Name="SAMSUNG S23", Stock=70, Price=28000, SubCategoryId=8},
                     new Product() { Id=16, Name="SAMSUNG FE", Stock=50, Price=17000, SubCategoryId=8}

               );
        }
    }
}


