﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RetroMusic.Entity.EntityModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RetroDatabaseEntities1 : DbContext
    {
        public RetroDatabaseEntities1()
            : base("name=RetroDatabaseEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<PurchasedSong> PurchasedSongs { get; set; }
        public virtual DbSet<Song> Songs { get; set; }
    }
}
