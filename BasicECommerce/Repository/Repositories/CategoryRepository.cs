using Core.DTOs;
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
    public class CategoryRepository : GenericRepository<ParentCategory>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }


        public async Task<List<ParentCategory>> GetCategoriesAsync()
        {
            return await _context.ParentCategories.Include(x => x.Categories.OrderBy(x => x.CategoryName)).ThenInclude(x => x.SubCategories.OrderBy(x => x.SubCategoryName)).ToListAsync();
            
        }
    }
}
