
using Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ProductController : CustomBaseController
    {
       
        private readonly IProductsService _productsService;

        public ProductController(IProductsService productsService)
        { 
           
            _productsService=productsService;
        }

      
        [HttpGet]
        [Route("category/{id}")]
        public async Task<IActionResult> GetProductsWithCategory(int id)
        {
            return CreateActionResult(await _productsService.GetProductsWithCategory(id));
        }

        [HttpGet]
        [Route("sub-category/{id}")]
        public async Task<IActionResult> GetProductsWithSubCategory(int id)
        {
            return CreateActionResult(await _productsService.GetProductsWithSubCategory(id));
        }

        [HttpGet]
        [Route("parent-category/{id}")]
        public async Task<IActionResult> GetProductsWithParentCategory(int id)
        {
            return CreateActionResult(await _productsService.GetProductsWithParentCategory(id));
        }

    }
}
