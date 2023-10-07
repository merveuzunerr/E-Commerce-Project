using Core.DTOs;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IProductsService : IService<Product>
    {
        Task<CustomResponseDto<ICollection<ProductDto>>> GetProductsWithCategory(int id);
        Task<CustomResponseDto<ICollection<ProductDto>>> GetProductsWithSubCategory(int id);
        Task<CustomResponseDto<ICollection<ProductDto>>> GetProductsWithParentCategory(int id);
    }
}
