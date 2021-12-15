﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.constant;
using Shop.entities;
using Shop.services;

namespace Shop.api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/products")]
    public class ProductController : GeneralController<Product, IProductService>
    {
        private Response response;
        private IProductService _productService;
        public ProductController(IProductService productService) : base(productService)
        {

            response = new Response();
            _productService = productService;
        }
        [HttpPost("add")]
        public Response Create([FromBody] Product product)
        {
            var data = this._productService.Add(product);
            response.Status = (int)Configs.STATUS_SUCCESS;
            response.Data = data;
            response.Message = "Success";
            return response;
        }

        [HttpGet("get-all")]
        public Response GetAll()
        {
            var datas = this._productService.GetProduct();
            response.Status = (int)Configs.STATUS_SUCCESS;
            response.Data = datas;
            response.Message = "Success";
            return response;
        }
    }
}
