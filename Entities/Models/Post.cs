namespace Entities.Models;

public class Post
{
 public int Id { get; set; }
 public string Header { get; set; }
 public string Body { get; set; }
 public ICollection<Vote> Votes { get; set; }
 public ICollection<Comment> Comments { get; set; }
 public string WrittenBy { get; set; }

 public Post(int id, string header, string body, ICollection<Vote> votes, ICollection<Comment> comments, string writtenBy)
 {
  Id = id;
  Header = header;
  Body = body;
  Votes = votes;
  Comments = comments;
  WrittenBy = writtenBy;
 }

 public Post(string header, string body, string writtenBy)
 {
  Header = header;
  Body = body;
  WrittenBy = writtenBy;
 }

 public Post(string header, string body, ICollection<Vote> votes, ICollection<Comment> comments, string writtenBy)
 {
  Header = header;
  Body = body;
  Votes = votes;
  Comments = comments;
  WrittenBy = writtenBy;
 }

 public Post()
 {
 }


}