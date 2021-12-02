using Shop.entities;

namespace Shop.services
{
    public interface IUserService : IGeneralService<User>
    {
        User Login(string username, string password);
    }
}
