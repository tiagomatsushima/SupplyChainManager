using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SupplyChainManager.Models
{
    public class Product : Entity
    {
        [DisplayName("Supplier Name")]
        public Guid SupplierId { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(200, ErrorMessage = "{0} needs to between {2} and {1}", MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(1000, ErrorMessage = "{0} needs to between {2} and {1}", MinimumLength = 2)]
        public string Description { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(200, ErrorMessage = "{0} needs to between {2} and {1}", MinimumLength = 2)]
        public string Image { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        public decimal Price { get; set; }
        
        [DisplayName("Register Date")]
        public DateTime RegisterDate { get; set; }

        [DisplayName("Is Active?")]
        public bool Active { get; set; }

        /* EF Relation */
        public Supplier Supplier { get; set; }
    }
}
