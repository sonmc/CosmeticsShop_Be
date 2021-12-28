
using Shop.entities; 
using Shop.repositories;
using System.Collections.Generic;

namespace Shop.services.ServiceImpl
{
    public class OrderService : GeneralServiceImpl<Order, IOrderRepository>, IOrderService
    {
        IOrderRepository _repository;

        public OrderService() { }
        public OrderService(IOrderRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public List<Order> SearchOrderByCode(string code)
        {
            return _repository.SearchOrderByCode(code);
        }
    }
}
