using Entities.Models;

namespace Contracts.Interfaces;

public interface IPostHomeService
{
    public Task AddNewPostAsync(string ownedBy, string title, string description);
}