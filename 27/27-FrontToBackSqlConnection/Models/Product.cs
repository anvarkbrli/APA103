namespace _27_FrontToBackSqlConnection.Models
{
    public class Product : BaseEntity
    {
        public int Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string SKU { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public List<ProductImage> ProductImages { get; set; }
    }
}
