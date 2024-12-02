using MainApp.Interfaces;
using MainApp.Models;

namespace MainApp.Services;

public class UserService : IUserService
{
    public void CreateUser(User user)
    {
        AddUserToList(user);
    }
}
