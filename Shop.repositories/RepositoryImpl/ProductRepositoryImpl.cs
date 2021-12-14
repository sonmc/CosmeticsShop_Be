using Shop.entities;

namespace Shop.repositories.RepositoryImpl
{
    public class ProductRepositoryImpl : GeneralRepositoryImpl<Product, DataContext>, IProductRepository
    {
        DataContext _dbContext;
        public ProductRepositoryImpl(DataContext context) : base(context)
        {
            this._dbContext = context;
        }
 
    }
}
