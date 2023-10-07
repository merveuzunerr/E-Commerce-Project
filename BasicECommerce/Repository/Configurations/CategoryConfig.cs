using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configurations
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
          
            builder.ToTable("Categories");
            builder.HasMany(x => x.SubCategories).WithOne(x => x.Category);
            builder.HasOne(x => x.ParentCategory).WithMany(x => x.Categories).HasForeignKey(x => x.ParentCategoryId); 
          
        }
    }
    
}
