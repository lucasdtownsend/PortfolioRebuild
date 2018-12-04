using PortfolioRebuild.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace PortfolioRebuild.DAL
{
    public class ProjectContext : DbContext
    {
        // Constructor
        public ProjectContext() : base("ProjectContext")
        {
            Database.SetInitializer(new ProjectInitializer());
        }

        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}