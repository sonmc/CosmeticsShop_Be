using Shop.entities;
using Shop.entities.Models;

namespace Shop.repositories.RepositoryImpl
{
    public class CategoryRepositoryImpl : GeneralRepositoryImpl<Category, DataContext>, ICategoryRepository
    {
        DataContext _dbContext;
        public CategoryRepositoryImpl(DataContext context) : base(context)
        {
            this._dbContext = context;
        }
    }
}
