using PojectMastery.Models;

namespace PojectMastery.Interfaces;

public interface ICategoryRepository
{
    public Task<IEnumerable<Category>> GetAllCategories();
    public Task<Category?> GetCategoryById<T>(T id);
}