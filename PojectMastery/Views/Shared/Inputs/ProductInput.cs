using PojectMastery.Models;

namespace PojectMastery.Views.Shared.Inputs;

public class ProductInput
{
    public string name { get; set; }
    public string description { get; set; }
    public string sku { get; set; }
    public string size { get; set; }
    public string color { get; set; }
    public int categoryId { get; set; }
    public IFormFile? productPhoto { get; set; }
    public decimal weight { get; set; }
    public decimal price { get; set; }

    public ProductInput(Product product)
    {
        name = product.name;
        description = product.description;
        sku = product.sku;
        size = product.size;
        color = product.color;
        categoryId = product.categoryId;
        weight = product.weight;
        price = product.price;
    }

    public Product ToProduct()
    {
        return new Product(
                    name,
                    description,
                    urlPhoto: null,
                    sku,
                    size,
                    color,
                    categoryId,
                    weight,
                    price
                );
    }
}