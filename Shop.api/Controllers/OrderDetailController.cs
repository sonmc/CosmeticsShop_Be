using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.entities;
using Shop.services;

namespace Shop.api.Controllers
{ 
    [Authorize]
    [ApiController]
    [Route("api/orderDetail")]
    public class OrderDetailController : GeneralController<OrderDetail, IOrderDetailService>
    {
        public OrderDetailController(IOrderDetailService orderDetailService) : base(orderDetailService)
        {
        }
    }
}
