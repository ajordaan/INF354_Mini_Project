﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace INF354Project
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class inf_354_dbEntities : DbContext
    {
        public inf_354_dbEntities()
            : base("name=inf_354_dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<car> cars { get; set; }
        public virtual DbSet<car_type> car_type { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<customer_title> customer_title { get; set; }
        public virtual DbSet<rental> rentals { get; set; }
    }
}
