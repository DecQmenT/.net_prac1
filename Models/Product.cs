

namespace TodoApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string ? Description { get; set; }
        public int Price { get; set; }
        public required string Category { get; set; }
        public string ? Subcategory { get; set; }
    }
}