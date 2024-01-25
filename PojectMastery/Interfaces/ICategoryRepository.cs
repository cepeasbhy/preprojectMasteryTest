using PojectMastery.Models;

namespace PojectMastery.Interfaces;

public interface ICategoryRepository
{
    public Task<IEnumerable<Category>> GetAllCategory();
    public Task<Category?> GetCategoryById<T>(T id);
}