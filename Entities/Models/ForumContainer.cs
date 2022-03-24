namespace Entities.Models;

public class ForumContainer
{
    public ICollection<Post> Posts { get; set; }
    public ICollection<User> Users { get; set; }
}