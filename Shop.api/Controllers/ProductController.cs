using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.entities;
using Shop.services;

namespace Shop.api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/product")]
    public class ProductController : GeneralController<Product, IProductService>
    {
        public ProductController(IProductService productService) : base(productService)
        {
        }
    }
}
