﻿using Core.Models;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<ICollection<Product>> GetProducts()
        {

            return await _context.Products.Include(x => x.SubCategory).ThenInclude(x => x.Category).ThenInclude(x=> x.ParentCategory).ToListAsync();
        }
       
    }
}
