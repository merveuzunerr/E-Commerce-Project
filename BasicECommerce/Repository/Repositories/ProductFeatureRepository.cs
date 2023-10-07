using Core.Models;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Repository.Repositories
{
    public class ProductFeatureRepository : GenericRepository<ProductFeature>, IProductFeatureRepository
    {
        public ProductFeatureRepository(AppDbContext context) : base(context)
        {
        }
        
        public async Task<List<ProductFeature>> GetProductFeature(int id)
        {
            return await _context.ProductFeature.Where(x => x.ProductId == id ).Include(x => x.Product).ToListAsync();
        }

   
    }
}
