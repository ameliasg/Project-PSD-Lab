﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectPSD.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MakeMeUpzzDatabaseEntities : DbContext
    {
        public MakeMeUpzzDatabaseEntities()
            : base("name=MakeMeUpzzDatabaseEntities4")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<MakeupBrand> MakeupBrands { get; set; }
        public virtual DbSet<Makeup> Makeups { get; set; }
        public virtual DbSet<MakeupType> MakeupTypes { get; set; }
        public virtual DbSet<TransactionDetail> TransactionDetails { get; set; }
        public virtual DbSet<TransactionHeader> TransactionHeaders { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
