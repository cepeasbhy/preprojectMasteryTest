namespace PojectMastery.Models
{
    public class Pagination
    {
        public int pageSize { get; set; }
        public int currentPage { get; set; }
        public string searchValue { get; set; }
        public int offset { get { return (currentPage - 1) * pageSize; } }
    }
}
