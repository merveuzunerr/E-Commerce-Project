using Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    public class CategoriesController : CustomBaseController
    {
      
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            
            _categoryService=categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            return CreateActionResult(await _categoryService.GetCategoriesAsync());
        }
    }
}
