using Shop.entities;
using System.Collections.Generic;
using System.Linq;

namespace Shop.repositories.RepositoryImpl
{
    public class OrderDetailRepositoryImpl : GeneralRepositoryImpl<OrderDetail, DataContext>, IOrderDetailRepository
    {
        DataContext _dbContext;
        public OrderDetailRepositoryImpl(DataContext context) : base(context)
        {
            this._dbContext = context;
        }

        public List<OrderDetail> GetByOrderId(int orderId)
        {
            return _dbContext.OrderDetails.Where(x => x.OrderId == orderId).ToList();
        }
    }
}
