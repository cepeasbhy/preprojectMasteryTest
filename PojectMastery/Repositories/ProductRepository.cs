using System.Data;
using Dapper;
using Microsoft.Identity.Client;
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

    public async Task<IEnumerable<Product>> GetPaginatedResult(Pagination pagination)
    { 
        return await _connection.QueryAsync<Product>(
            "sp_get_paginated_result", 
            new { 
                pagination.offset, 
                search = pagination.searchValue, 
                next = pagination.pageSize
            });
    }

    public async Task<int> GetTotalProducts() {
        return await _connection.QuerySingleAsync<int>("sp_get_total_products");
    }

    public async Task<int> GetTotalCategories() {
        return await _connection.QuerySingleAsync<int>("sp_get_total_category");
    }

    public async Task<int> GetTotalSearchResult(string searchText) {
        return await _connection.QuerySingleAsync<int>(
            "sp_get_total_search_results", 
            new { search = searchText });
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

    public async Task<int> UpdateProduct<T>(T id, Product product)
    {
        return await _connection.ExecuteAsync(
            "sp_save_product", 
            new
            {
                id,
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