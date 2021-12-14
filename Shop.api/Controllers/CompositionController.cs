﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.constant;
using Shop.entities;
using Shop.services;

namespace Shop.api.Controllers
{ 
    [Authorize]
    [ApiController]
    [Route("api/compositions")]
    public class CompositionController : GeneralController<Composition, ICompositionService>
    {
        private ICompositionService _compositionService;
        private Response response;
        public CompositionController(ICompositionService compositionService) : base(compositionService)
        {
            response = new Response();
            _compositionService = compositionService;
        }
        [HttpPost("add")]
        public Response Create([FromBody] Composition composition)
        {
            composition.ProductId = (int)Configs.ID_PRODUCT_DEFAULT;
            var data = this._compositionService.Add(composition);
            response.Status = (int)Configs.STATUS_SUCCESS;
            response.Data = data;
            response.Message = "Success";
            return response;
        }
    }
}