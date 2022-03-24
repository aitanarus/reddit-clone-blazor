using System.Text.Json;
using Entities.Models;

namespace JsonDataAccess.DataAccess;
public class JsonContext
{
    private string forumPath = "forum.json";

    private ForumContainer? forum;
    
    public ForumContainer Forum
    {
        get
        {
            if (forum == null)
            {
                LoadData();
            }

            return forum!;
        }
    }

    public JsonContext()
    {
        if (File.Exists(forumPath))
        {
            LoadData();
        }
        else
        {
            CreateFile();
        }
    }
    

    private void CreateFile()
    {
        forum = new ForumContainer();
        Task.FromResult(SaveChangesAsync());
    }

    private void LoadData()
    {
        string forumAsJson = File.ReadAllText(forumPath);
        forum = JsonSerializer.Deserialize<ForumContainer>(forumAsJson)!;
    }

    public async Task SaveChangesAsync()
    {
        string forumAsJson = JsonSerializer.Serialize(forum, new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNameCaseInsensitive = false
        });
        
        await File.WriteAllTextAsync(forumPath,forumAsJson);
        forum = null;
    }
}