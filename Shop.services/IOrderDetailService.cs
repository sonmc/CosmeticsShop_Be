using Shop.entities;
using System.Collections.Generic;

namespace Shop.services
{
    public interface IOrderDetailService : IGeneralService<OrderDetail>
    {
        public List<OrderDetail> GetByOrderId(int orderId);
    }
}
