using System.ComponentModel.DataAnnotations;

namespace WebApplication6.Model
{
    public class ProductList
    {
        [Key]
        public int Id { get; set; }
        [Required]
    
        public string? ProductName { get; set; }
    
        [Required]
       
        public string? ProductDetails { get; set; }
       
        [Required]
        [Range(1,100,ErrorMessage = "QTY must be 1-100!")]
        public int ProductQty { get; set; }

    }
}
