using Core.DTOs;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface ICartService : IService<Cart>
    {
        Task<CustomResponseDto<CartWithUserIdDto>> AddCart(AddToCartDto cart, int? id);
        Task<CustomResponseDto<string>> RemoveCart(int userId, int productId);
        Task<CustomResponseDto<List<CartDto>>> GetCart(int id);
        Task<CustomResponseDto<AddToCartDto>> UpdateCart(AddToCartDto addToBasket, int id);
        Task<CustomResponseDto<string>> Order(int id);
    }
}
