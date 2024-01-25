using System.Data;
using Dapper;
using PojectMastery.Interfaces;
using PojectMastery.Models;

namespace PojectMastery.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly IDbConnection _connection;

    public ProductRepository(IDbConnection connection)
    {
        _connection = connection;
    }

    public async Task<IEnumerable<Product>> GetAllProducts()
    {
        return await _connection.QueryAsync<Product>("sp_get_products");
    }

    public async Task<Product?> GetProductById<T>(T id)
    {
        var products = await _connection.QueryAsync<Product?>(
            "sp_get_product_by_id", 
            new { id }
            );
        return products.FirstOrDefault();
    }

    public async Task<int> AddProduct(Product product)
    {
        return await _connection.ExecuteAsync(
            "sp_save_product", 
            new
            {
                product.name,
                product.description,
                product.urlPhoto,
                product.sku,
                product.size,
                product.color,
                product.categoryId,
                product.weight,
                product.price
            },
            commandType: CommandType.StoredProcedure
        ); 
    }
}