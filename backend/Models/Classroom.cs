using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace backend.Models;

public class Classroom
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    public string Name { get; set; } = null!;

    [BsonRepresentation(BsonType.ObjectId)]
    public string? Teacher { get; set; }


    [BsonRepresentation(BsonType.ObjectId)]
    public List<string?> Students { get; set; } = null!;
    
    
    [BsonRepresentation(BsonType.ObjectId)]
    public List<string?> AssignedChallenges { get; set; } = null!;
}