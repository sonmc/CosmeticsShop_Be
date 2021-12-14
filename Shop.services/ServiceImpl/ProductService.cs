using Shop.entities;
using Shop.repositories; 

namespace Shop.services.ServiceImpl
{
    public class ProductService : GeneralServiceImpl<Product, IProductRepository>, IProductService
    {
        IProductRepository _repository;

        public ProductService() { }
        public ProductService(IProductRepository repository) : base(repository)
        {
            _repository = repository;
        } 
    }
}
