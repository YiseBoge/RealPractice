using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace backend.Models;

public class Classroom
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    public string Name { get; set; } = null!;

    public ObjectId Teacher { get; set; }

    public List<ObjectId> Students { get; set; } = null!;
    
    public List<ObjectId> AssignedChallenges { get; set; } = null!;
}