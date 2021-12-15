using Shop.entities;
using System.Collections.Generic;

namespace Shop.repositories
{
    public interface IOrderDetailRepository : IGeneralRepository<OrderDetail>
    {
        public List<OrderDetail> GetByOrderId(int orderId);
    }
}
