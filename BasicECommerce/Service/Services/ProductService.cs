using AutoMapper;
using Core.DTOs;
using Core.Models;
using Core.Repositories;
using Core.Services;
using Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ProductService : Service<Product>, IProductsService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IGenericRepository<Product> repository, IUnitOfWork unitOfWork, IProductRepository productrepository, IMapper mapper)
            : base(repository, unitOfWork)
        {
            _productRepository=productrepository;
            _mapper=mapper;
        }



        public async Task<CustomResponseDto<ICollection<ProductDto>>> GetProductsWithCategory(int id)
        {
            var products = await _productRepository.GetProducts();
            var _products= products.Where(x => x.SubCategory.CategoryId== id).ToList();
            var productsDto = _mapper.Map<ICollection<ProductDto>>(_products);
            
            return CustomResponseDto<ICollection<ProductDto>>.Success(200, productsDto);
        }


        public async Task<CustomResponseDto<ICollection<ProductDto>>> GetProductsWithSubCategory(int id)
        {
            var products = await _productRepository.GetProducts();
            var _products = products.Where(x => x.SubCategoryId== id).ToList();
            var productsDto = _mapper.Map<ICollection<ProductDto>>(_products);

            return CustomResponseDto<ICollection<ProductDto>>.Success(200, productsDto);
        }

        public async Task<CustomResponseDto<ICollection<ProductDto>>> GetProductsWithParentCategory(int id)
        {
            var products = await _productRepository.GetProducts();
            var _products = products.Where(x => x.SubCategory.Category.ParentCategoryId== id).ToList();
            var productsDto = _mapper.Map<ICollection<ProductDto>>(_products);

            return CustomResponseDto<ICollection<ProductDto>>.Success(200, productsDto);
        }

    }
}
