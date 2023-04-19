using backend.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Bson;
using backend.Config;

namespace backend.Services;

public class SolutionService
{

    private readonly IMongoCollection<Solution> _solutionsCollection;

    public SolutionService(IOptions<MongoDBSettings> mongoDBSettings)
    {
        MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
        IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
        _solutionsCollection = database.GetCollection<Solution>(mongoDBSettings.Value.SolutionCollection);
    }



    public async Task<List<Solution>> GetAsync()
    {
        return await _solutionsCollection.Find(new BsonDocument()).ToListAsync();
    }




    public async Task<Solution> GetbyIdAsync(string id)
    {
        var filter = Builders<Solution>.Filter.Eq(r => r.Id, id);
        return await _solutionsCollection.Find(filter).FirstOrDefaultAsync();
    }



    public async Task<List<Solution>> GetbySolverIdAsync(string id)
    {
        var filter = Builders<Solution>.Filter.Eq(r => r.SolverStudent, id);
        return await _solutionsCollection.Find(filter).ToListAsync();
    }



    public async Task CreateAsync(Solution solution)
    {
        await _solutionsCollection.InsertOneAsync(solution);
        return;
    }



    public async Task UpdateAsync(string id, Solution solution)
    {
        var filter = Builders<Solution>.Filter
                    .Eq("Id", id);

        var update = Builders<Solution>.Update
            .Set(sol => sol.remark, solution.remark)
            .Set(sol => sol.score, solution.score);

        var result = await _solutionsCollection.UpdateOneAsync(filter, update);
        return;

    }



    public async Task DeleteAsync(string id)
    {
        FilterDefinition<Solution> filter = Builders<Solution>.Filter.Eq("Id", id);
        await _solutionsCollection.DeleteOneAsync(filter);
        return;
    }


}