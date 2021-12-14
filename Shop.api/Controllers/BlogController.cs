using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.constant;
using Shop.entities;
using Shop.services;
using System;

namespace Shop.api.Controllers
{

    [Authorize]
    [ApiController]
    [Route("api/blogs")]
    public class BlogController : GeneralController<Blog, IBlogService>
    {
        private IBlogService blogService;
        private Response response;
        public BlogController(IBlogService blogService) : base(blogService)
        {
            this.blogService = blogService;
            response = new Response();
        }
        [HttpPost("add")]
        public Response Create([FromBody] Blog blog)
        {
            blog.CreatedDate = DateTime.Now.ToString();
            var data = this.blogService.Add(blog);
            response.Status = (int)Configs.STATUS_SUCCESS;
            response.Data = data;
            response.Message = "Success";
            return response;
        }
    }
}
