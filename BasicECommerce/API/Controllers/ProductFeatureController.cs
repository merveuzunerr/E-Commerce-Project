using Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ProductFeatureController : CustomBaseController
    {
        private readonly IProductFeatureService _productFeatureService;

        public ProductFeatureController(IProductFeatureService productFeatureService)
        {

            _productFeatureService=productFeatureService;
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductsWithCategory(int id)
        {
            return CreateActionResult(await _productFeatureService.GetProductFeature(id));
        }

    }
}
