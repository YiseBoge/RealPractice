using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace backend.Models;

public class Solution
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    public string Content { get; set; } = null!;

    public ObjectId SolverStudent { get; set; }

    public ObjectId Challenge { get; set; }

    public string remark {get; set;} = null!;

    public int score {get; set;}

    public int time {get; set;}
}

