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
    
    public partial class tbl_ItemSpecification
    {
        public string CompanyCode { get; set; }
        public string ItemCode { get; set; }
        public string ItemService { get; set; }
        public string DetailItemCode { get; set; }
        public string DetailItemUnit { get; set; }
        public Nullable<decimal> ItemQuantity { get; set; }
        public Nullable<decimal> UnitTransValue { get; set; }
    
        public virtual tbl_ItemSpecification tbl_ItemSpecification1 { get; set; }
        public virtual tbl_ItemSpecification tbl_ItemSpecification2 { get; set; }
    }
}
