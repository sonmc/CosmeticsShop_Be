
using Microsoft.AspNetCore.Mvc;
using Shop.constant;
using Shop.entities;
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
        private ICustomerService _customerService;
        private IOrderService _orderService;
        private Response response;
        public HomeController(ICategoryService categoryService, IOrderService orderService, ICustomerService customerService,
            IProductService productService, IBrandService brandService)
        {
            _categoryService = categoryService;
            _productService = productService;
            _brandService = brandService;
            _customerService = customerService;
            _orderService = orderService;
            response = new Response();
        }


        [HttpGet("products")]
        public Response GetProduct(int brandId)
        {
            var data = _productService.GetByBrandId(brandId);
            response.Status = (int)Configs.STATUS_SUCCESS;
            response.Data = data;
            response.Message = "Success";
            return response;
        }

        [HttpGet("categories")]
        public Response GetCategory()
        {
            var data = _categoryService.GetAll();

            response.Status = (int)Configs.STATUS_SUCCESS;
            response.Data = data;
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

        [HttpPost("create-customer")]
        public Response CreateCustomer(Customer customer)
        {
            var data = _customerService.Add(customer);
            response.Status = (int)Configs.STATUS_SUCCESS;
            response.Data = data;
            response.Message = "Success";
            return response;
        }

        [HttpPost("create-order")]
        public Response CreateOrder(Order order)
        {
            var data = _orderService.Add(order);
            response.Status = (int)Configs.STATUS_SUCCESS;
            response.Data = data;
            response.Message = "Success";
            return response;
        }
    }
}
