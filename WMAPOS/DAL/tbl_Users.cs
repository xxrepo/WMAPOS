//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Users()
        {
            this.tbl_operators = new HashSet<tbl_operators>();
        }
    
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullNameA { get; set; }
        public string FullNameE { get; set; }
        public string GroupCode { get; set; }
        public string UserStatus { get; set; }
        public Nullable<bool> IsCasher { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ModefiedBy { get; set; }
        public Nullable<System.DateTime> ModefiedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_operators> tbl_operators { get; set; }
        public virtual tbl_UserGroup tbl_UserGroup { get; set; }
    }
}
