using Shop.entities;

namespace Shop.repositories.RepositoryImpl
{
    public class OrderDetailRepositoryImpl : GeneralRepositoryImpl<OrderDetail, DataContext>, IOrderDetailRepository
    {
        DataContext _dbContext;
        public OrderDetailRepositoryImpl(DataContext context) : base(context)
        {
            this._dbContext = context;
        }
    }
}
