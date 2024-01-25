using System.Data;
using Dapper;
using PojectMastery.Interfaces;
using PojectMastery.Models;

namespace PojectMastery.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly IDbConnection _connection;

    public CategoryRepository(IDbConnection connection)
    {
        _connection = connection;
    }
    
    public async Task<IEnumerable<Category>> GetAllCategory()
    {
        return await _connection.QueryAsync<Category>("sp_get_categories");
    }

    public async Task<Category?> GetCategoryById<T>(T id)
    {
        var categories = await _connection.QueryAsync<Category?>(
            "sp_get_category_by_id", 
            new { id }
        );
        return categories.FirstOrDefault();
    }
}