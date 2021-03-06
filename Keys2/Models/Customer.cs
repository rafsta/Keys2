//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Keys2.Models
{
    using System;
    using System.Collections.Generic;

    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.ProductSolds = new HashSet<ProductSold>();
        }

        [Required]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Id is not valid.")]
        public int Id { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Customer name can only contain letters.")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Customer name should be between 3 and 10 letters")]
        [DisplayName(displayName: "Customer Name")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Your address is too long.")]
        public string Address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductSold> ProductSolds { get; set; }
    }
}
