using backend.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Bson;

namespace backend.Services;

public class CompanyService
{

    private readonly IMongoCollection<Company> _companiesCollection;

    public CompanyService(IOptions<MongoDBSettings> mongoDBSettings)
    {
        MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
        IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
        _companiesCollection = database.GetCollection<Company>(mongoDBSettings.Value.CompanyCollection);

    }


    public async Task<List<Company>> GetAsync()
    {
        return await _companiesCollection.Find(new BsonDocument()).ToListAsync();
    }


    public async Task<Company> GetbyIdAsync(string id)
    {
        var filter = Builders<Company>.Filter.Eq(r => r.Id, id);
        return await _companiesCollection.Find(filter).FirstOrDefaultAsync();
    }




    public async Task CreateAsync(Company company)
    {
        await _companiesCollection.InsertOneAsync(company);
        return;
    }




    public async Task UpdateAsync(string id, Company company)
    {
        var filter = Builders<Company>.Filter
                    .Eq("Id", id);

        var update = Builders<Company>.Update
            .Set(comp => comp.Name, company.Name)
            .Set(comp => comp.Challenges, company.Challenges)
            .Set(comp => comp.Email, company.Email)
            .Set(comp => comp.Password, company.Password);

        var result = await _companiesCollection.UpdateOneAsync(filter, update);
        return;

    }




    public async Task DeleteAsync(string id)
    {
        FilterDefinition<Company> filter = Builders<Company>.Filter.Eq("Id", id);
        await _companiesCollection.DeleteOneAsync(filter);
        return;
    }


}