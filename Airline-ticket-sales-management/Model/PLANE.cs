//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Airline_ticket_sales_management.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class PLANE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PLANE()
        {
            this.FLIGHTs = new HashSet<FLIGHT>();
            this.SEATs = new HashSet<SEAT>();
        }
    
        public string PlaneID { get; set; }
        public string PlaneName { get; set; }
        public int SeatCount { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FLIGHT> FLIGHTs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEAT> SEATs { get; set; }
    }
}
