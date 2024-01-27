using PojectMastery.Models;

namespace PojectMastery.Interfaces;

public interface IProductRepository
{
    public Task<IEnumerable<Product>> GetPaginatedResult(Pagination pagination);
    public Task<int> GetTotalProducts();
    public Task<int> GetTotalCategories();
    public Task<int> GetTotalSearchResult(string searchText);
    public Task<Product?> GetProductById<T>(T id);
    public Task<int> AddProduct(Product product);
    
}