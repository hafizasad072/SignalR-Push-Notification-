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
    
    public partial class Device
    {
        public int DeviceId { get; set; }
        public string DeviceName { get; set; }
        public System.DateTime AddDate { get; set; }
        public Nullable<int> AddedBy { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<System.DateTime> ApprovalDate { get; set; }
        public Nullable<int> ApprovedBy { get; set; }
        public Nullable<int> ApprovalStatusId { get; set; }
    }
}
