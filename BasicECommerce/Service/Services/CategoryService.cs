using AutoMapper;
using Core.DTOs;
using Core.Models;
using Core.Repositories;
using Core.Services;
using Core.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class CategoryService : Service<ParentCategory>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        //private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;


        public CategoryService(IGenericRepository<ParentCategory> repository, IUnitOfWork unitOfWork, ICategoryRepository categoryRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _categoryRepository=categoryRepository;
            _mapper=mapper;
            
        }

        public async Task<CustomResponseDto<ICollection<ParentCategoryDto>>> GetCategoriesAsync()
        {
            var categories = await _categoryRepository.GetCategoriesAsync();
            var categoriesDto= _mapper.Map<ICollection<ParentCategoryDto>>(categories.ToList());
            
            return CustomResponseDto<ICollection<ParentCategoryDto>>.Success(200, categoriesDto);
        }
    }
}
