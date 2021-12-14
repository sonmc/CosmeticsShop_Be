using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.entities;
using Shop.services;

namespace Shop.api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/orders")]
    public class OrderController : GeneralController<Order, IOrderService>
    {
        public OrderController(IOrderService orderService) : base(orderService)
        {
        }
    }
}
