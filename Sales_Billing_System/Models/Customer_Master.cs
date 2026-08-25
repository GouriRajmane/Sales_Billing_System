using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace Sales_Billing_System.Models
{
    public class Customer_Master
    {
        [Key]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Customer Name is required.")]
        [StringLength(100)]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Mobile Number is required.")]
        [StringLength(15)]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Mobile Number should contain only numbers.")]
        public string MobileNumber { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(15)]
        public string? GSTIN { get; set; }

        // Navigation Property
        public virtual ICollection<Sales_Invoice_Item> SalesInvoiceItems { get; set; }
            = new List<Sales_Invoice_Item>();


    }
}