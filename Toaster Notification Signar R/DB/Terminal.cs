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
    
    public partial class Terminal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Terminal()
        {
            this.Heartbeats = new HashSet<Heartbeat>();
            this.Tasks = new HashSet<Task>();
            this.TerminalLanguages = new HashSet<TerminalLanguage>();
            this.TerminalServices = new HashSet<TerminalService>();
            this.Transactions = new HashSet<Transaction>();
        }
    
        public int TerminalID { get; set; }
        public string TerminalName { get; set; }
        public int ZoneId { get; set; }
        public int LocationId { get; set; }
        public string Address { get; set; }
        public int CityId { get; set; }
        public int ProvinceId { get; set; }
        public int CountryId { get; set; }
        public Nullable<int> TerminalStatusId { get; set; }
        public int NoteStackAlertId { get; set; }
        public Nullable<int> StackedNotesLimit { get; set; }
        public Nullable<System.DateTime> AddDate { get; set; }
        public bool Postpaid { get; set; }
        public bool Prepaid { get; set; }
        public Nullable<int> AddedBy { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<System.DateTime> ApprovalDate { get; set; }
        public Nullable<int> ApprovedBy { get; set; }
        public Nullable<int> ApprovalStatusId { get; set; }
    
        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Heartbeat> Heartbeats { get; set; }
        public virtual Location Location { get; set; }
        public virtual Province Province { get; set; }
        public virtual StackAlert StackAlert { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Task> Tasks { get; set; }
        public virtual TerminalStatu TerminalStatu { get; set; }
        public virtual Zone Zone { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TerminalLanguage> TerminalLanguages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TerminalService> TerminalServices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
