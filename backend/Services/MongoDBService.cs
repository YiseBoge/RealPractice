using backend.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Bson;

namespace backend.Services;

public class MongoDBService
{

    private readonly IMongoCollection<User> _usersCollection;

    public MongoDBService(IOptions<MongoDBSettings> mongoDBSettings)
    {
        MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
        IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
        _usersCollection = database.GetCollection<User>(mongoDBSettings.Value.UserCollection);
    }

    public async Task<List<User>> GetAsync()
    {
        return await _usersCollection.Find(new BsonDocument()).ToListAsync();
    }


    public async Task<User> GetbyIdAsync(string id)
    {
        var filter = Builders<User>.Filter.Eq(r => r.Id, id);
        return await _usersCollection.Find(filter).FirstOrDefaultAsync();
    }

    public async Task CreateAsync(User user)
    {
        await _usersCollection.InsertOneAsync(user);
        return;
    }


    public async Task DeleteAsync(string id)
    {
        FilterDefinition<User> filter = Builders<User>.Filter.Eq("Id", id);
        await _usersCollection.DeleteOneAsync(filter);
        return;
    }


}