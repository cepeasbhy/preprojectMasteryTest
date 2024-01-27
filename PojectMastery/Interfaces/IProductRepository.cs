using PojectMastery.Models;

namespace PojectMastery.Interfaces;

public interface IProductRepository
{
    public Task<IEnumerable<Product>> GetAllProducts();
    public Task<Product?> GetProductById<T>(T id);
    public Task<int> AddProduct(Product product);
    public Task<int> UpdateProduct<T>(T id, Product product);
}