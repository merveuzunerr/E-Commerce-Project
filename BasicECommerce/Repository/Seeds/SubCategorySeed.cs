using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Seeds
{
    public class SubCategorySeed : IEntityTypeConfiguration<SubCategory>
    {
        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            builder.HasData(
                new SubCategory() { Id=1, SubCategoryName="Buzdolabı", CategoryId=1 },
                new SubCategory() { Id=2, SubCategoryName="Laptop", CategoryId= 2},
                new SubCategory() { Id=3, SubCategoryName="Kettle", CategoryId=3},
                new SubCategory() { Id=4, SubCategoryName="Blender", CategoryId=3 },
                new SubCategory() { Id=5, SubCategoryName="Tartı", CategoryId=3 },
                new SubCategory() { Id=6, SubCategoryName="Airfryer", CategoryId=3},
                new SubCategory() { Id=7, SubCategoryName="IOS Telefonlar", CategoryId=4 },
                new SubCategory() { Id=8, SubCategoryName="Samsung Telefonlar", CategoryId=4 }
               );
        }
    }
}
