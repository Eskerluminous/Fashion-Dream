//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FashionDream.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Variation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Variation()
        {
            this.Carts = new HashSet<Cart>();
        }
    
        public int VariationID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public Nullable<int> ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual Product Product { get; set; }
        public virtual UserAccount UserAccount { get; set; }
    }
}