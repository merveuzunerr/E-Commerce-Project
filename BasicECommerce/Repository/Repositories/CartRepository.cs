using Core.Models;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class CartRepository : GenericRepository<Cart>, ICartRepository
    {
        public CartRepository(AppDbContext context) : base(context)
        {
        }


        public async Task<List<Cart>> GetCartsAsync(int id)
        {
            return await _context.Carts.Where(x => x.UserAccountId==id && x.IsActive==true).Include(x => x.Products).ToListAsync();
 
        }
    }
}
