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
    public class CartConfig
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.HasMany(x => x.Products).WithMany(x => x.Carts);
            builder.HasOne(x => x.UserAccount).WithOne(x => x.Cart).HasForeignKey<Cart>(x => x.UserAccountId);
        }
        
    }
}
