using backend.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Bson;
using backend.Config;

namespace backend.Services;

public class UserService
{


    private readonly IMongoCollection<User> _usersCollection;

    public UserService(IOptions<MongoDBSettings> mongoDBSettings)
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



    public async Task UpdateAsync(string id, User user)
    {
        var filter = Builders<User>.Filter
                    .Eq("Id", id);

        var update = Builders<User>.Update
            .Set(usr => usr.Name, user.Name)
            .Set(usr => usr.Email, user.Email)
            .Set(usr => usr.Password, user.Password)
            .Set(usr => usr.Role, user.Role)
            .Set(usr => usr.Classrooms, user.Classrooms)
            .Set(usr => usr.Solutions, user.Solutions);

        var result = await _usersCollection.UpdateOneAsync(filter, update);
        return;

    }


    public async Task DeleteAsync(string id)
    {
        FilterDefinition<User> filter = Builders<User>.Filter.Eq("Id", id);
        await _usersCollection.DeleteOneAsync(filter);
        return;
    }


      public async Task<User?> AuthenticateUser(string Username, string Password)
    {
        var filter = Builders<User>.Filter.Eq(r => r.Name, Username);
        var user = await _usersCollection.Find(filter).FirstOrDefaultAsync();

        if (user == null)
        {
            return null;
        }

        if (user.Password != Password)
        {
            return null;
        }

        return user;
    }


}