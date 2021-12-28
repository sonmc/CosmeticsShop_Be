using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.constant;
using Shop.services;

namespace Shop.api.Controllers
{
    [ApiController]
    [Route("api/homes")]
    public class HomeController : Controller
    {
        private ICategoryService _categoryService;
        private IProductService _productService;
        private IBrandService _brandService;
        private Response response;
        public HomeController(ICategoryService categoryService, IProductService productService, IBrandService brandService)
        {
            _categoryService = categoryService;
            _productService = productService;
            _brandService = brandService;
            response = new Response();
        }


        [HttpGet("products")]
        public Response GetProduct(int brandId)
        {
            var datas = _productService.GetByBrandId(brandId);
            response.Status = (int)Configs.STATUS_SUCCESS;
            response.Data = datas;
            response.Message = "Success";
            return response;
        }

        [HttpGet("categories")]
        public Response GetCategory()
        {
            var categories = _categoryService.GetAll();

            response.Status = (int)Configs.STATUS_SUCCESS;
            response.Data = categories;
            response.Message = "Success";
            return response;
        }
        [HttpGet("brands")]
        public Response GetBrand(int categoryId)
        {
            var datas = _brandService.GetByCategoryId(categoryId);
            response.Status = (int)Configs.STATUS_SUCCESS;
            response.Data = datas;
            response.Message = "Success";
            return response;
        }
    }
}
