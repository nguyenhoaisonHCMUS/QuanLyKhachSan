//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelManagement
{
    using System;
    using System.Collections.Generic;
    
    public partial class ThucPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThucPham()
        {
            this.PhieuSuDungThucPhams = new HashSet<PhieuSuDungThucPham>();
        }
    
        public int mathucpham { get; set; }
        public string tenthucpham { get; set; }
        public Nullable<int> soluongton { get; set; }
        public Nullable<double> gia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuSuDungThucPham> PhieuSuDungThucPhams { get; set; }
    }
}
