using Shop.entities;
using System.Collections.Generic;

namespace Shop.services
{
    public interface IProductService : IGeneralService<Product>
    {
        public List<Product> GetProduct();
    }
}
