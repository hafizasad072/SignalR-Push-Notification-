//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Toaster_Notification_Signar_R.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class TerminalService
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TerminalService()
        {
            this.TerminalServiceVendors = new HashSet<TerminalServiceVendor>();
        }
    
        public int TerminalServiceID { get; set; }
        public int ServiceID { get; set; }
        public int TerminalID { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime AddDate { get; set; }
        public Nullable<int> AddedBy { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    
        public virtual Service Service { get; set; }
        public virtual Terminal Terminal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TerminalServiceVendor> TerminalServiceVendors { get; set; }
    }
}
