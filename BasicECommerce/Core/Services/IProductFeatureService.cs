using Core.DTOs;
using Core.Models;
using Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IProductFeatureService : IService<ProductFeature>
    {
        Task<CustomResponseDto<ICollection<ProductFeatureDto>>> GetProductFeature(int id);
    }
}
