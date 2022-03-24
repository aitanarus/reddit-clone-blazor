using Radzen.Blazor;

namespace Entities.Models;

public class Vote
{
    public int Value { get; set; }
    public string User { get; set; }

    public Vote(int value, string user)
    {
        Value = value;
        User = user;
    }
}