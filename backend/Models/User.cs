using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace backend.Models;

public class User
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Role { get; set; } = null!;

    [BsonRepresentation(BsonType.ObjectId)]
    public List<string?> Classrooms { get; set; } = null!;
    

    [BsonRepresentation(BsonType.ObjectId)]
    public List<string?> Solutions { get; set; } = null!;

}