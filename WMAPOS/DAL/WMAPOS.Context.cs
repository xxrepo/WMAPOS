﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WMAPOSEntities : DbContext
    {
        public WMAPOSEntities()
            : base("name=WMAPOSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_Barcodes> tbl_Barcodes { get; set; }
        public virtual DbSet<tbl_Branch> tbl_Branch { get; set; }
        public virtual DbSet<tbl_Company> tbl_Company { get; set; }
        public virtual DbSet<tbl_Currency> tbl_Currency { get; set; }
        public virtual DbSet<tbl_CurrencyExch> tbl_CurrencyExch { get; set; }
        public virtual DbSet<tbl_CustomerGroup> tbl_CustomerGroup { get; set; }
        public virtual DbSet<tbl_Cutomers> tbl_Cutomers { get; set; }
        public virtual DbSet<tbl_ItemCategory> tbl_ItemCategory { get; set; }
        public virtual DbSet<tbl_ItemColor> tbl_ItemColor { get; set; }
        public virtual DbSet<tbl_ItemDefinition> tbl_ItemDefinition { get; set; }
        public virtual DbSet<tbl_ItemGroup> tbl_ItemGroup { get; set; }
        public virtual DbSet<tbl_ItemGroupSections> tbl_ItemGroupSections { get; set; }
        public virtual DbSet<tbl_ItemPolicies> tbl_ItemPolicies { get; set; }
        public virtual DbSet<tbl_ItemPrices> tbl_ItemPrices { get; set; }
        public virtual DbSet<tbl_ItemSize> tbl_ItemSize { get; set; }
        public virtual DbSet<tbl_ItemType> tbl_ItemType { get; set; }
        public virtual DbSet<tbl_ItemUnit> tbl_ItemUnit { get; set; }
        public virtual DbSet<tbl_operators> tbl_operators { get; set; }
        public virtual DbSet<tbl_POS_Definition> tbl_POS_Definition { get; set; }
        public virtual DbSet<tbl_UserGroup> tbl_UserGroup { get; set; }
        public virtual DbSet<tbl_Users> tbl_Users { get; set; }
        public virtual DbSet<tbl_VendorGroup> tbl_VendorGroup { get; set; }
        public virtual DbSet<tbl_Vendors> tbl_Vendors { get; set; }
        public virtual DbSet<tbl_WareHouse> tbl_WareHouse { get; set; }
    }
}
