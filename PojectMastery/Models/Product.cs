namespace PojectMastery.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string urlPhoto { get; set; }
        public string sku { get; set; }
        public string size { get; set; }
        public string color { get; set; }
        public int categoryId { get; set; }
        public IFormFile productPhoto { get; set; }
        public decimal weight { get; set; }
        public decimal price { get; set; }
        public DateTime? dateAdded { get; set; }
        public DateTime? dateModified { get; set; }
        public DateTime? dateDeleted { get; set; }
    }
}
