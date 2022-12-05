namespace SuggestionAppLibrary.DataAccess;

public interface IStatusData
{
   Task<List<StatusModel>> GetAllStatusesAsync();
   Task CreateStatus(StatusModel status);
}