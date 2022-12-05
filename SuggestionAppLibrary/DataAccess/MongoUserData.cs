namespace SuggestionAppLibrary.DataAccess;

public class MongoUserData : IUserData
{

   private readonly IMongoCollection<UserModel> _users;
   
   public MongoUserData(IDbConnection db)
   {
      _users = db.UserCollection;
   }

   public async Task<List<UserModel>> GetAllUserAsync()
   {
      var results = await _users.FindAsync(x => true);
      return results.ToList();
   }

   public async Task<UserModel> GetUser(string id)
   {
      var results = await _users.FindAsync(x => x.Id == id);
      return results.FirstOrDefault();
   }

   public async Task<UserModel> GetUserFromAuthentication(string objectId)
   {
      var results = await _users.FindAsync(x => x.ObjectIdentifier == objectId);
      return results.FirstOrDefault();
   }

   public Task CreateUser(UserModel user)
   {
      return _users.InsertOneAsync(user);
   }

   public Task UpdateUser(UserModel user)
   {
      return _users.ReplaceOneAsync(x => x.Id == user.Id, user, new ReplaceOptions { IsUpsert = true });
   }
}