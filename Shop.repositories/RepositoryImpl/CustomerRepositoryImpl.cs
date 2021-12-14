using Shop.entities; 

namespace Shop.repositories.RepositoryImpl
{
    public class CustomerRepositoryImpl : GeneralRepositoryImpl<Customer, DataContext>, ICustomerRepository
    {
        DataContext _dbContext;
        public CustomerRepositoryImpl(DataContext context) : base(context)
        {
            this._dbContext = context;
        }
    }
}
