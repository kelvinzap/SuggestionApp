namespace SuggestionAppLibrary.DataAccess;

public interface ICategoryData
{
   Task<List<CategoryModel>> GetAllCategoriesAsync();
   Task CreateCategory(CategoryModel category);
}