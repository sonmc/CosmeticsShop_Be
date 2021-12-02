using Shop.entities;
using Shop.repositories; 

namespace Shop.services.ServiceImpl
{
    public class CategoryService : GeneralServiceImpl<Category, ICategoryRepository>, ICategoryService
    {
    }
}
