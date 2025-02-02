using System.ComponentModel.DataAnnotations;

namespace APIConcepts.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")][StringLength(100, ErrorMessage = "Name can't be longer than 100 characters")] public string Name { get; set; }
        [Range(0.01, 1000.00, ErrorMessage = "Price must be between 0.01 and 1000.00")] public decimal Price { get; set; }


    }
}
