using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.constant;
using Shop.entities;
using Shop.helpers;
using Shop.services;

namespace Shop.api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/categories")]
    public class CategoryController : GeneralController<Category, ICategoryService> 
    { 
        public CategoryController(ICategoryService categoryService) : base(categoryService)
        { 
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
