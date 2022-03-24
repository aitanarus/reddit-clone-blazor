using Contracts.Interfaces;
using Entities.Models;

namespace Application.Authentication;

public class InMemoryUserService: IUserService
{
    public Task<User?> GetUserAsync(string username)
    {
        User? find = users.Find(user => user.UserName.Equals(username));
        return Task.FromResult(find);
    }

    private List<User> users = new()
    {
        new User { UserName = "Troels", Password = "Troels1234"},
        new User { UserName = "Maria", Password = "oneTwo3FOUR"},
        new User { UserName = "Anne", Password = "password"}
    };
}