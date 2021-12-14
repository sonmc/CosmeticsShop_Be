using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.constant;
using Shop.entities;
using Shop.services;

namespace Shop.api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/orders")]
    public class OrderController : GeneralController<Order, IOrderService>
    {
        private readonly IOrderService _orderService;
        private readonly ICustomerService _customerService;
        private Response response;
        public OrderController(IOrderService orderService, ICustomerService customerService) : base(orderService)
        {
            _orderService = orderService;
            _customerService = customerService;
            response = new Response();
        }
        [HttpGet("get-orders")]
        public Response GetAll()
        {
            var orders = this._orderService.GetAll();
            foreach (var item in orders)
            {
                var customer = _customerService.Get(item.CustomerId);
                item.CustomerName = customer.Name;
                item.CustomerPhoneNumber = customer.PhoneNumber;
                item.CustomerAddress = customer.Address;
            }
            response.Status = (int)Configs.STATUS_SUCCESS;
            response.Data = orders;
            response.Message = "Success";
            return response;
        }
    }
}
