namespace Entities.Models;

public class Post
{
 public int Id { get; set; }
 public string Header { get; set; }
 public string Body { get; set; }
 
 public string Image { get; set; }
 public DateTime DateTime { get; set; }
 public ICollection<Vote> Votes { get; set; }
 public ICollection<Comment> Comments { get; set; }
 public string WrittenBy { get; set; }

 public Post(int id, string header, string body, string image, ICollection<Vote> votes, ICollection<Comment> comments, string writtenby)
 {
  Id = id;
  Header = header;
  Body = body;
  Image = image;
  Votes = votes;
  Comments = comments;
  WrittenBy = writtenby;
  DateTime = DateTime.Now;
 }
 public Post(int id, string header, string body, ICollection<Vote> votes, ICollection<Comment> comments, string writtenby)
 {
  Id = id;
  Header = header;
  Body = body;
  Votes = votes;
  Comments = comments;
  WrittenBy = writtenby;
  DateTime = DateTime.Now;
 }
 

 public Post(string header, string body, ICollection<Vote> votes, ICollection<Comment> comments, string writtenBy)
 {
  Header = header;
  Body = body;
  Votes = votes;
  Comments = comments;
  WrittenBy = writtenBy;
  DateTime = DateTime.Now;
 }

 public Post() {}


}