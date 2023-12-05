using System.ComponentModel.DataAnnotations;

namespace ProductAPI.Entities
{
    public class Category : BaseEntity
    {
        [MaxLength(50, ErrorMessage = "the name must have up to 50 characters")]
        public string Name { get; set; }
        
        [MaxLength(150, ErrorMessage = "the description must have up to 150 characters")]
        public string Description { get; set; }
    }
}