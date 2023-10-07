using AutoMapper;
using Core.DTOs;
using Core.Models;
using Core.Repositories;
using Core.Services;
using Core.UnitOfWorks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ProductFeatureService : Service<ProductFeature>, IProductFeatureService
    {
        private readonly IProductFeatureRepository _productFeatureRepository;
        private readonly IMapper _mapper;


        public ProductFeatureService(IGenericRepository<ProductFeature> repository, IUnitOfWork unitOfWork, IProductFeatureRepository productFeaturerepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _productFeatureRepository=productFeaturerepository;
            _mapper=mapper;
        }


        public async Task<CustomResponseDto<ICollection<ProductFeatureDto>>> GetProductFeature(int id)
        {
            var productFeature = await _productFeatureRepository.GetProductFeature(id);

            if (productFeature.IsNullOrEmpty())
            {
                return CustomResponseDto<ICollection<ProductFeatureDto>>.Fail(404, $"The product with id number {id} not found");
            }

            else
            {
                var productFeatureDto = _mapper.Map<ICollection<ProductFeatureDto>>(productFeature);
                return CustomResponseDto<ICollection<ProductFeatureDto>>.Success(200, productFeatureDto);
            }
        }
    
    }
}
