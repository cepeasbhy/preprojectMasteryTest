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
<<<<<<< Updated upstream
    public Task<int> UpdateProduct<T>(T id, Product product);
=======
<<<<<<< HEAD
    
=======
    public Task<int> UpdateProduct<T>(T id, Product product);
>>>>>>> 5d3f44c8fe01715afd02542ae52684c20b6d26fa
>>>>>>> Stashed changes
}