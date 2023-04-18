using backend.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Bson;

namespace backend.Services;

public class MongoDBService
{

    private readonly IMongoCollection<User> _usersCollection;
    private readonly IMongoCollection<Company> _companiesCollection;
    private readonly IMongoCollection<Challenge> _challengesCollection;
    private readonly IMongoCollection<Classroom> _classroomsCollection;
    private readonly IMongoCollection<Solution> _solutionsCollection;

    public MongoDBService(IOptions<MongoDBSettings> mongoDBSettings)
    {
        MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
        IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);

        _usersCollection = database.GetCollection<User>(mongoDBSettings.Value.UserCollection);
        _companiesCollection = database.GetCollection<Company>(mongoDBSettings.Value.CompanyCollection);
        _challengesCollection = database.GetCollection<Challenge>(mongoDBSettings.Value.ChallengeCollection);
        _classroomsCollection = database.GetCollection<Classroom>(mongoDBSettings.Value.ClassroomCollection);
        _solutionsCollection = database.GetCollection<Solution>(mongoDBSettings.Value.SolutionCollection);
    }

    public async Task<List<User>> GetUsersAsync()
    {
        return await _usersCollection.Find(new BsonDocument()).ToListAsync();
    }

    public async Task<List<Company>> GetCompaniesAsync()
    {
        return await _companiesCollection.Find(new BsonDocument()).ToListAsync();
    }


    public async Task<List<Challenge>> GetChallengesAsync()
    {
        return await _challengesCollection.Find(new BsonDocument()).ToListAsync();
    }


    public async Task<List<Classroom>> GetClassroomsAsync()
    {
        return await _classroomsCollection.Find(new BsonDocument()).ToListAsync();
    }


    public async Task<List<Solution>> GetSolutionsAsync()
    {
        return await _solutionsCollection.Find(new BsonDocument()).ToListAsync();
    }



    public async Task<User> GetUserbyIdAsync(string id)
    {
        var filter = Builders<User>.Filter.Eq(r => r.Id, id);
        return await _usersCollection.Find(filter).FirstOrDefaultAsync();
    }


    public async Task<Company> GetCompanybyIdAsync(string id)
    {
        var filter = Builders<Company>.Filter.Eq(r => r.Id, id);
        return await _companiesCollection.Find(filter).FirstOrDefaultAsync();
    }

    public async Task<Challenge> GetChallengebyIdAsync(string id)
    {
        var filter = Builders<Challenge>.Filter.Eq(r => r.Id, id);
        return await _challengesCollection.Find(filter).FirstOrDefaultAsync();
    }


    public async Task<Classroom> GetClassroombyIdAsync(string id)
    {
        var filter = Builders<Classroom>.Filter.Eq(r => r.Id, id);
        return await _classroomsCollection.Find(filter).FirstOrDefaultAsync();
    }


    public async Task<Solution> GetSolutionbyIdAsync(string id)
    {
        var filter = Builders<Solution>.Filter.Eq(r => r.Id, id);
        return await _solutionsCollection.Find(filter).FirstOrDefaultAsync();
    }

    public async Task CreateUserAsync(User user)
    {
        await _usersCollection.InsertOneAsync(user);
        return;
    }


    public async Task CreateCompanyAsync(Company company)
    {
        await _companiesCollection.InsertOneAsync(company);
        return;
    }


    public async Task CreateChallengeAsync(Challenge challenge)
    {
        await _challengesCollection.InsertOneAsync(challenge);
        return;
    }


    public async Task CreateClassroomAsync(Classroom classroom)
    {
        await _classroomsCollection.InsertOneAsync(classroom);
        return;
    }


    public async Task CreateSolutionAsync(Solution solution)
    {
        await _solutionsCollection.InsertOneAsync(solution);
        return;
    }


    public async Task UpdateUserAsync(string id, User user)
    {
        var filter = Builders<User>.Filter
                    .Eq("Id", id);

        var update = Builders<User>.Update
            .Set(usr => usr.Name, user.Name)
            .Set(usr => usr.Classrooms, user.Classrooms)
            .Set(usr => usr.Email, user.Email)
            .Set(usr => usr.Role, user.Role)
            .Set(usr => usr.Solutions, user.Solutions)
            .Set(usr => usr.Password, user.Password);

        var result = await _usersCollection.UpdateOneAsync(filter, update);
        return;

    }


    public async Task UpdateCompanyAsync(string id, Company company)
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


    public async Task UpdateChallengeAsync(string id, Challenge challenge)
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



    public async Task UpdateClassroomAsync(string id, Classroom classroom)
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


    public async Task UpdateSolutionAsync(string id, Solution solution)
    {
        var filter = Builders<Solution>.Filter
                    .Eq("Id", id);

        var update = Builders<Solution>.Update
            .Set(sol => sol.Content, solution.Content)
            .Set(sol => sol.SolverStudent, solution.SolverStudent)
            .Set(sol => sol.Challenge, solution.Challenge)
            .Set(sol => sol.remark, solution.remark)
            .Set(sol => sol.score, solution.score)
            .Set(sol => sol.time, solution.time);

        var result = await _solutionsCollection.UpdateOneAsync(filter, update);
        return;

    }

    public async Task DeleteUserAsync(string id)
    {
        FilterDefinition<User> filter = Builders<User>.Filter.Eq("Id", id);
        await _usersCollection.DeleteOneAsync(filter);
        return;
    }

    public async Task DeleteCompanyAsync(string id)
    {
        FilterDefinition<Company> filter = Builders<Company>.Filter.Eq("Id", id);
        await _companiesCollection.DeleteOneAsync(filter);
        return;
    }


    public async Task DeleteChallengeAsync(string id)
    {
        FilterDefinition<Challenge> filter = Builders<Challenge>.Filter.Eq("Id", id);
        await _challengesCollection.DeleteOneAsync(filter);
        return;
    }


    public async Task DeleteClassroomAsync(string id)
    {
        FilterDefinition<Classroom> filter = Builders<Classroom>.Filter.Eq("Id", id);
        await _classroomsCollection.DeleteOneAsync(filter);
        return;
    }

    public async Task DeleteSolutionAsync(string id)
    {
        FilterDefinition<Solution> filter = Builders<Solution>.Filter.Eq("Id", id);
        await _solutionsCollection.DeleteOneAsync(filter);
        return;
    }


}