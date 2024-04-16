using Repitition.Models;

namespace Repitition.Repository;

public interface IUserRepository
{
    List<User> GetUsersAsync();
    User GetUserAsync(int id);
    Response CreateUserAsync(User newUser);
    Response DeleteUserAsync(int id);
}
