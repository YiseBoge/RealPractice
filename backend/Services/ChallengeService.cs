using backend.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Bson;
using backend.Config;

namespace backend.Services;

public class ChallengeService
{


    private readonly IMongoCollection<Challenge> _challengesCollection;

    public ChallengeService(IOptions<MongoDBSettings> mongoDBSettings)
    {
        MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
        IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);

        _challengesCollection = database.GetCollection<Challenge>(mongoDBSettings.Value.ChallengeCollection);
    }

  
    public async Task<List<Challenge>> GetAsync()
    {
        return await _challengesCollection.Find(new BsonDocument()).ToListAsync();
    }



    public async Task<Challenge> GetbyIdAsync(string id)
    {
        var filter = Builders<Challenge>.Filter.Eq(r => r.Id, id);
        return await _challengesCollection.Find(filter).FirstOrDefaultAsync();
    }


    public async Task CreateAsync(Challenge challenge)
    {
        await _challengesCollection.InsertOneAsync(challenge);
        return;
    }



    public async Task UpdateAsync(string id, Challenge challenge)
    {
        var filter = Builders<Challenge>.Filter
                    .Eq("Id", id);

        var update = Builders<Challenge>.Update
            .Set(chalng => chalng.Title, challenge.Title)
            .Set(chalng => chalng.Description, challenge.Description)
            .Set(chalng => chalng.Answer, challenge.Answer)
            .Set(chalng => chalng.Difficulty, challenge.Difficulty)
            .Set(chalng => chalng.Company, challenge.Company)
            .Set(chalng => chalng.AssignedTo, challenge.AssignedTo);
            

        var result = await _challengesCollection.UpdateOneAsync(filter, update);
        return;

    }


    public async Task DeleteAsync(string id)
    {
        FilterDefinition<Challenge> filter = Builders<Challenge>.Filter.Eq("Id", id);
        await _challengesCollection.DeleteOneAsync(filter);
        return;
    }


}