using Shop.entities;
using Shop.repositories;
using System.Collections.Generic;

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

        public List<OrderDetail> GetByOrderId(int orderId)
        {
            return _repository.GetByOrderId(orderId);
        }
    }
}
