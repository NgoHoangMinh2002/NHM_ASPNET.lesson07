//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NhmK22CNT3Lss07.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NhmKhoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhmKhoa()
        {
            this.nhmsinhvien4 = new HashSet<nhmsinhvien4>();
        }
    
        public string NhmMaKH { get; set; }
        public string NhmTenKH { get; set; }
        public Nullable<bool> NhmTrangThai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nhmsinhvien4> nhmsinhvien4 { get; set; }
    }
}
