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
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category() { Id=1, CategoryName="Beyaz Eşya", ParentCategoryId=1 },
                new Category() { Id=2, CategoryName="Bilgisayar", ParentCategoryId= 1 },
                new Category() { Id=3, CategoryName="Küçük Ev Aletleri", ParentCategoryId = 1 },
                new Category() { Id=4, CategoryName="Telefon", ParentCategoryId = 1 }
               );
        }
    }
}
