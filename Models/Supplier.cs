using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SupplyChainManager.Models
{
    public class Supplier : Entity
    {
        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(200, ErrorMessage = "{0} needs to between {2} and {1}", MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(14, ErrorMessage = "{0} needs to between {2} and {1}", MinimumLength = 11)]
        public string Document { get; set; }

        public SupplierType SupplierType { get; set; }
        public Address Address { get; set; }

        [DisplayName("Is Active?")]
        public bool Active { get; set; }

        /* EF Relation */
        public IEnumerable<Product> Products { get; set; }
    }
}
