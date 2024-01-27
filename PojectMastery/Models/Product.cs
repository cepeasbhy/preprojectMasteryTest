namespace PojectMastery.Models
{
    public class Product
    {

        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
<<<<<<< Updated upstream

        public string? urlPhoto { get; set; }
=======
<<<<<<< HEAD
        public string urlPhoto { get; set; }
=======
        
        public string? urlPhoto { get; set; }
>>>>>>> 5d3f44c8fe01715afd02542ae52684c20b6d26fa
>>>>>>> Stashed changes
        public string sku { get; set; }
        public string size { get; set; }
        public string color { get; set; }
        public int categoryId { get; set; }
        public decimal weight { get; set; }
        public decimal price { get; set; }

        public DateTime? dateAdded { get; set; }

        public DateTime? dateModified { get; set; }

        public DateTime? dateDeleted { get; set; }

        public Product() { }

        public Product(string name, string description, string urlPhoto, string sku, string size, string color, int categoryId, decimal weight, decimal price)
        {
            this.name = name;
            this.description = description;
            this.urlPhoto = urlPhoto;
            this.sku = sku;
            this.size = size;
            this.color = color;
            this.categoryId = categoryId;
            this.weight = weight;
            this.price = price;
        }

        public override string ToString()
        {
            return $"Product: {id} {name} {description} {urlPhoto} {sku} {size} {color} {categoryId} {weight} {price}";
        }
    }
}
