namespace SuggestionAppLibrary.DataAccess;

public interface ISuggestionData
{
   Task<List<SuggestionModel>> GetAllSuggestionsAsync();
   Task<List<SuggestionModel>> GetAllApprovedSuggestions();
   Task<SuggestionModel> GetSuggestion(string id);
   Task<List<SuggestionModel>> GetAllSuggestionsWaitingForApproval();
   Task UpdateSuggestion(SuggestionModel suggestion);
   Task UpvoteSuggestion(string suggestionId, string userId);
   Task CreateSuggestion(SuggestionModel suggestion);
}