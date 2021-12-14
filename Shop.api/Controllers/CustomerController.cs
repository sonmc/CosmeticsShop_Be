using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.constant;
using Shop.entities;
using Shop.services;

namespace Shop.api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/customers")]
    public class CustomerController : GeneralController<Customer, ICustomerService>
    {
        private ICustomerService customerService;
        private Response response;
        public CustomerController(ICustomerService customerService) : base(customerService)
        {
            this.customerService = customerService;
            response = new Response();
        }
    }
}
