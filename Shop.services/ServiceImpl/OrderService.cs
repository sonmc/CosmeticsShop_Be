
using Shop.entities; 
using Shop.repositories;  

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
    
    }
}
