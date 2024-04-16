using Repitition.Models;

namespace Repitition.Repository;

public class UserRepository : IUserRepository
{
    private static List<User> Users = new List<User>()
    {
        new User
        {
            Id = 1,
            Username = "foziljonov7",
            Age = 19,
            PhoneNumber = "+998945666964",
            Address = "Fergana region"
        }
    };
    public Response CreateUserAsync(User newUser)
    {
        var user = new User
        {
            Id = newUser.Id,
            Username = newUser.Username,
            Address = newUser.Address,
            PhoneNumber = newUser.PhoneNumber,
            Age = newUser.Age
        };

        Users.Add(user);
        return new Response(true, "Successfully saved");
    }

    public Response DeleteUserAsync(int id)
    {
        var user = Users.Find(u => u.Id == id);

        if (user is null)
            return new Response(false, "Invalid operation");

        Users.Remove(user);
        return new Response(true, "Successfully deleted");
    }

    public User GetUserAsync(int id)
    {
        var user = Users.Find(u => u.Id == id);

        if (user is null)
            throw new ArgumentNullException(nameof(id), "Null reference");

        return user;
    }

    public List<User> GetUsersAsync()
    {
        List<User> users = Users;
        return users;
    }
}
