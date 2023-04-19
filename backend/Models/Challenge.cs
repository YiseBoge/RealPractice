using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace backend.Models;

public class Challenge
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Answer { get; set; } = null!;

    public string Difficulty {get; set; } = null!;


    [BsonRepresentation(BsonType.ObjectId)]
    public string? Company { get; set; }


    [BsonRepresentation(BsonType.ObjectId)]
    public List<string?> AssignedTo { get; set; }


}