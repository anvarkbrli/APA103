using System.ComponentModel.DataAnnotations;

namespace _27_FrontToBackSqlConnection.Models
{
    public class Category: BaseEntity
    {
        [Required]
        [MaxLength(30, ErrorMessage ="Please input correctly")]
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
