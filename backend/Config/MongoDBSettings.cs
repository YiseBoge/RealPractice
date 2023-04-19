namespace backend.Config;

public class MongoDBSettings
{

    public string ConnectionURI { get; set; } = null!;

    public string DatabaseName { get; set; } = null!;

    public string UserCollection { get; set; } = null!;

    public string CompanyCollection { get; set; } = null!;

    public string ChallengeCollection {get; set;} = null!;

    public string ClassroomCollection {get; set;} = null!;
    
    public string SolutionCollection {get; set;} = null!;

}