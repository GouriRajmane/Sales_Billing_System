using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Sales_Billing_System.Models
{
    public class Customer_Master
    {
        // - Customer ID
        //- Customer Name
        //- Mobile Number
        //- Address
        //- GSTIN(optional)

        [Key]
        public int CustomerId { get; set; }

        [Required]
        [StringLength(100)]
        public string CustomerName { get; set; }

        [Required]
        [StringLength(15)]
        public string MobileNumber { get; set; }

        [Required]
        [StringLength(200)]
        public string Address { get; set; }


        [StringLength(15)]
        public string? GSTIN { get; set; }


    }
}
