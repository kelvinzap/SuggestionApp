namespace SuggestionAppLibrary.DataAccess;

public interface IUserData
{
   Task<List<UserModel>> GetAllUserAsync();
   Task<UserModel> GetUser(string id);
   Task<UserModel> GetUserFromAuthentication(string objectId);
   Task CreateUser(UserModel user);
   Task UpdateUser(UserModel user);
}