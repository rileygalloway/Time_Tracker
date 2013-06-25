using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TimeTrackerUser.Models
{
    public class TimeTrackerEntities : DbContext
    {
        public DbSet<ServiceOrganization> ServiceOrganizations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ServiceOrganization>().ToTable("ServiceOrganizations", "internal");
        }
    }
}