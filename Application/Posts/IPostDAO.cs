using Entities.Models;

namespace Application.NewPost;


public interface IPostDAO
{
    public Task<ICollection<Post>> GetAsync(); 
    public Task<Post> AddAsync(Post post);
    public Task<Post> GetById(int id);
    public Task<Post> UpdateCommentsAndVotesAsync(Post post, Comment comment, Vote vote);
}