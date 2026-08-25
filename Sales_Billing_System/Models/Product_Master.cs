using System.ComponentModel.DataAnnotations;

namespace Sales_Billing_System.Models
{
    public class Product_Master
    {
        //- Product ID
        //- Product Name
        //- SKU(optional)
        //- Unit
        //- Selling Price
        //- GST %   (optional)
        //- Is Active

        [Key]
        public int ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }

        [StringLength(50)]
        public string? SKU { get; set; }

        [Required]
        [StringLength(20)]
        public string Unit { get; set; }


        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Selling Price must be a positive value.")]
        public decimal SellingPrice { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "GST % must be between 0 and 100.")]
        public decimal GSTPercentage { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Required]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        

    }
}
