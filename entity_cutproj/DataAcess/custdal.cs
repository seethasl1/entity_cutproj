using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using entity_cutproj.Models;

namespace entity_cutproj.DataAcess
{
    public class custdal:DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<customer>().ToTable("customer");
            modelBuilder.Entity<Login>().ToTable("usr_Login");
        }
        public DbSet<customer> Customers { get; set; }
        public DbSet<Login> Logins { get; set; }

    }
}