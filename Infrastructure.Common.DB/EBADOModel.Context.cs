﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infrastructure.Common.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EBADODBEntities : DbContext
    {
        public EBADODBEntities(string connectionString)
            : base(connectionString)
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AccountTypeDbo> Account_Type { get; set; }
        public virtual DbSet<UserAccountDbo> UserAccountDboes { get; set; }
        public virtual DbSet<AddressDbo> AddressDboes { get; set; }
        public virtual DbSet<CategoryDbo> CategoryDboes { get; set; }
        public virtual DbSet<LocationDbo> LocationDboes { get; set; }
        public virtual DbSet<MainCategoryDbo> MainCategoryDboes { get; set; }
        public virtual DbSet<SubCategoryDbo> SubCategoryDboes { get; set; }
        public virtual DbSet<UserRoleDbo> UserRoleDboes { get; set; }
    }
}
