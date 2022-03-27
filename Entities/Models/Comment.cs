namespace Entities.Models;

public class Comment
{
    public string Body { get; set; }
    public Comment ParentComment { get; set; }
    public ICollection<Vote> Votes { get; set; }
    public string WrittenBy { get; set; }



    public Comment(string body, Comment parentComment, ICollection<Vote> votes, string writtenBy)
    {
        Body = body;
        ParentComment = parentComment;
        Votes = votes;
        WrittenBy = writtenBy;
    }

    public Comment(string body, ICollection<Vote> votes, string writtenBy)
    {
        Body = body;
        Votes = votes;
        WrittenBy = writtenBy;
    }
    
    public Comment(){}
}