using PojectMastery.Models;

namespace PojectMastery.Interfaces;

public interface IProductRepository
{
    public Task<IEnumerable<Product>> GetAllProducts();
    public Task<Product?> GetProductById<T>(T id);

    public Task<int> AddProduct(Product product);
}