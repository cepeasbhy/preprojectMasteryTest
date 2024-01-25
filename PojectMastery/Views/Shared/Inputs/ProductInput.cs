using PojectMastery.Models;

namespace PojectMastery.Views.Shared.Inputs;

public class ProductInput
{
    public string name { get; set; }
    public string description { get; set; }
    public string sku { get; set; }
    public string size { get; set; }
    public string color { get; set; }
    public string categoryId { get; set; }
    public IFormFile productPhoto { get; set; }
    public decimal weight { get; set; }
    public decimal price { get; set; }
}