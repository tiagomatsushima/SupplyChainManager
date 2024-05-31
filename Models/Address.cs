using System.ComponentModel.DataAnnotations;

namespace SupplyChainManager.Models
{
    public class Address : Entity
    {
        public Guid SupplierId { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(200, ErrorMessage = "{0} needs to between {2} and {1}", MinimumLength = 2)]
        public  string Street { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(50, ErrorMessage = "{0} needs to between {2} and {1}", MinimumLength = 1)]
        public string Number { get; set; }

        public string Complement { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(8, ErrorMessage = "{0} needs to between {2} and {1}", MinimumLength = 8)]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(100, ErrorMessage = "{0} needs to between {2} and {1}", MinimumLength = 2)]
        public string Neighborhood { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(100, ErrorMessage = "{0} needs to between {2} and {1}", MinimumLength = 2)]
        public string City { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(50, ErrorMessage = "{0} needs to between {2} and {1}", MinimumLength = 2)]
        public string State { get; set; }

        /* EF Relation */
        public Supplier Supplier { get; set; }
    }
}
