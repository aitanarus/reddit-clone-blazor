namespace JsonDataAccess.DataAccess;

using Application.NewPost;
using Entities.Models;
public class JsonPostDAO : IPostDAO
{
    private JsonContext jsonContext;

    public JsonPostDAO(JsonContext jsonContext)
    {
        this.jsonContext = jsonContext;
    }

    public Task<ICollection<Post>> GetAsync()
    {
        ICollection<Post> posts = jsonContext.Forum.Posts;
        return Task.FromResult(posts);
    }

    public async Task<Post> AddAsync(Post post)
    {
        int largestId = jsonContext.Forum.Posts.Max(t => t.Id);
        int nextId = largestId + 1;
        post.Id = nextId;
        jsonContext.Forum.Posts.Add(post);
        await jsonContext.SaveChangesAsync();
        return post;
    }

    public Task<Post> GetById(int id)
    {
        return Task.FromResult(jsonContext.Forum.Posts.First(t => t.Id == id));
    }

    public async Task<Post> UpdateCommentsAndVotesAsync(Post post, Comment comment, Vote vote)
    {
        Post toUpdate = jsonContext.Forum.Posts.First(t => t.Id == post.Id);
        toUpdate.Comments.Add(comment);
        toUpdate.Votes.Add(vote);
        await jsonContext.SaveChangesAsync();
        return post;
    }
}