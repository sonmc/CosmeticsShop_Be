using Shop.entities;
using Shop.repositories;
using System.Collections.Generic;

namespace Shop.services.ServiceImpl
{
    public class ProductService : GeneralServiceImpl<Product, IProductRepository>, IProductService
    {
        IProductRepository _repository;
        ICategoryRepository _categoryRepository;

        public ProductService() { }
        public ProductService(IProductRepository repository, ICategoryRepository categoryRepository) : base(repository)
        {
            _repository = repository;
            _categoryRepository = categoryRepository;
        }
        public List<Product> GetProduct()
        {
            var products = _repository.GetListProduct();
            foreach (var item in products)
            {
                item.NameCategory = _categoryRepository.Get(item.CategoryId).Name;
            }
            return products;
        }
    }
}
