//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TownUtilityBillSystemV2
{
    using System;
    using System.Collections.Generic;
    
    public partial class STREET
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public STREET()
        {
            this.ADDRESSes = new HashSet<ADDRESS>();
            this.BUILDINGs = new HashSet<BUILDING>();
        }
    
        public int ID { get; set; }
        public string NAME { get; set; }
        public int TOWN_ID { get; set; }
        public int INDEX_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ADDRESS> ADDRESSes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BUILDING> BUILDINGs { get; set; }
        public virtual INDEX INDEX { get; set; }
        public virtual TOWN TOWN { get; set; }
    }
}