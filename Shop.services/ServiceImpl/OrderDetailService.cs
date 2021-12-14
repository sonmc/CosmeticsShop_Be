using Shop.entities;
using Shop.repositories; 

namespace Shop.services.ServiceImpl
{
    public class OrderDetailService : GeneralServiceImpl<OrderDetail, IOrderDetailRepository>, IOrderDetailService
    {
        IOrderDetailRepository _repository;

        public OrderDetailService() { }
        public OrderDetailService(IOrderDetailRepository repository) : base(repository)
        {
            _repository = repository;
        } 
    }
}
