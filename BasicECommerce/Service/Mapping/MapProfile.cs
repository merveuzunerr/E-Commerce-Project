using AutoMapper;
using Core.DTOs;
using Core.Models;

namespace Service.Mapping
{
    public class MapProfile: Profile
    {
      
        public MapProfile()
        {
            CreateMap<ParentCategory, ParentCategoryDto>().ReverseMap();
            CreateMap<ParentCategory, ParentCategoryNameDto>().ReverseMap();
            CreateMap<SubCategory, SubCategoryDto>().ReverseMap();
            CreateMap<SubCategory, SubCategoryWithProductDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryNameDto>().ReverseMap();
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Product, ProductNameDto>().ReverseMap();
            CreateMap<ProductFeature, ProductFeatureDto>().ReverseMap();
            CreateMap<UserAccount, UserAccountDto>().ReverseMap();
            CreateMap<Cart, CartDto>().ReverseMap();
            CreateMap<Cart, AddToCartDto>().ReverseMap();
            CreateMap<Cart, CartWithUserIdDto>().ReverseMap();
        }

    }
}
