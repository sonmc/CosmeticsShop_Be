using Shop.entities;
using System.Collections.Generic;
using System.Linq;

namespace Shop.repositories.RepositoryImpl
{
    public class ProductRepositoryImpl : GeneralRepositoryImpl<Product, DataContext>, IProductRepository
    {
        DataContext _dbContext;
        public ProductRepositoryImpl(DataContext context) : base(context)
        {
            this._dbContext = context;
        }
        
        public List<Product> GetListProduct()
        {
            return _dbContext.Products.Where(x => !x.IsDisabled).ToList();
        }
    }
}
