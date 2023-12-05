using System.ComponentModel.DataAnnotations;

namespace ProductAPI.Entities
{
    public class Product : BaseEntity
    {
        [MaxLength(155, ErrorMessage = "the name must have up to 155 characters")]
        public string Name { get; set; }
        
        public decimal Price { get; set; }
        
        public int CategoryId { get; set; }
        
        public Category Category { get; set; }
    }
}