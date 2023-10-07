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
    public class PrentCategoryConfig : IEntityTypeConfiguration<ParentCategory>
    {
        public void Configure(EntityTypeBuilder<ParentCategory> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.HasMany(x => x.Categories).WithOne(x => x.ParentCategory);
           

        }
    }

}
