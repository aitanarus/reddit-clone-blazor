using Entities.Models;

namespace Contracts.Interfaces;

public interface IUserService
{
    public Task<User?> GetUserAsync(string username);
}