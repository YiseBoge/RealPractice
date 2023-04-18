using backend.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Bson;

namespace backend.Services;

public class ClassroomService
{

    private readonly IMongoCollection<Classroom> _classroomsCollection;

    public ClassroomService(IOptions<MongoDBSettings> mongoDBSettings)
    {
        MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
        IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
        _classroomsCollection = database.GetCollection<Classroom>(mongoDBSettings.Value.ClassroomCollection);

    }

 

    public async Task<List<Classroom>> GetAsync()
    {
        return await _classroomsCollection.Find(new BsonDocument()).ToListAsync();
    }



    public async Task<Classroom> GetbyIdAsync(string id)
    {
        var filter = Builders<Classroom>.Filter.Eq(r => r.Id, id);
        return await _classroomsCollection.Find(filter).FirstOrDefaultAsync();
    }






    public async Task CreateAsync(Classroom classroom)
    {
        await _classroomsCollection.InsertOneAsync(classroom);
        return;
    }






    public async Task UpdateAsync(string id, Classroom classroom)
    {
        var filter = Builders<Classroom>.Filter
                    .Eq("Id", id);

        var update = Builders<Classroom>.Update
            .Set(cls => cls.Name, classroom.Name)
            .Set(cls => cls.Teacher, classroom.Teacher)
            .Set(cls => cls.Students, classroom.Students)
            .Set(cls => cls.AssignedChallenges, classroom.AssignedChallenges);

        var result = await _classroomsCollection.UpdateOneAsync(filter, update);
        return;

    }



    public async Task DeleteAsync(string id)
    {
        FilterDefinition<Classroom> filter = Builders<Classroom>.Filter.Eq("Id", id);
        await _classroomsCollection.DeleteOneAsync(filter);
        return;
    }


}