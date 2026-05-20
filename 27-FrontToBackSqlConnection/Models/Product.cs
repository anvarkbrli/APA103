namespace _27_FrontToBackSqlConnection.Models
{
    public class Product : BaseEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }
        public string Description { get; set; }
        public string SKU { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public List<ProductTag> ProductTags { get; set; }
    }
}
