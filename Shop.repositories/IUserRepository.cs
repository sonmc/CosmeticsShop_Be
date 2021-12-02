using Shop.entities;

namespace Shop.repositories
{
    public interface IUserRepository : IGeneralRepository<User>
    {
        User Login(string username, string password);
    }
}
