using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    [DbConfigurationType(typeof(MySql.Data.EntityFramework.MySqlEFConfiguration))]
    public class MyContext : DbContext
    {
        public DbSet<admin> Admins { get; set; }

        public DbSet<backup> Backups { get; set; }
        public DbSet<backup_source> Backup_sources { get; set; }
        public DbSet<backup_target> Backup_targets { get; set; }
        public DbSet<backup_time> Backup_times { get; set; }
        public DbSet<client> Clients { get; set; }
        public DbSet<job> Jobs { get; set; }
        public DbSet<job_history> Job_histories { get; set; }
        public DbSet<log> Logs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

}