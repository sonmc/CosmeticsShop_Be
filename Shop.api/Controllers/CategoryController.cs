using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.entities;
using Shop.services;

namespace Shop.api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/categories")]
    public class CategoryController : GeneralController<Category, ICategoryService>
    {
        private ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService) : base(categoryService)
        {
            this._categoryService = categoryService;
        }
    }
}
