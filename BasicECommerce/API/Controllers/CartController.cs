using Core.DTOs;
using Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class CartController : CustomBaseController
    { 
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService=cartService;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetCart(int id)
        {

            return CreateActionResult(await _cartService.GetCart(id));
        }

        [HttpPost("{id?}")]
        public async Task<IActionResult> AddCart(AddToCartDto cartDto, int? id=0)
        {

            return CreateActionResult(await _cartService.AddCart(cartDto, id));
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateCart(AddToCartDto addToCart, int id)
        {

            return CreateActionResult(await _cartService.UpdateCart(addToCart, id));
        }


        [HttpDelete]
        [Route("{userId}/{productId}")]
        public async Task<IActionResult> RemoveCart(int userId, int productId)
        {
            return CreateActionResult(await _cartService.RemoveCart(userId, productId));
        }

        [HttpDelete]
        [Route("order/{id}")]
        public async Task<IActionResult> Order(int id)
        {
            return CreateActionResult(await _cartService.Order(id));
        }

    }
}
