using Shop.entities;

namespace Shop.repositories.RepositoryImpl
{
    public class OrderRepositoryImpl : GeneralRepositoryImpl<Order, DataContext>, IOrderRepository
    {
        DataContext _dbContext;
        public OrderRepositoryImpl(DataContext context) : base(context)
        {
            this._dbContext = context;
        }
 
    }
}
