using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class TestContext : DbContext
    {
        public DbSet<telefony> Telefons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();

            // M:N relace mezi tabulkami Person <-> Course s mezitabulkou PersonCourse
            /*modelBuilder.Entity<Person>()
                .HasMany<Course>(s => s.Courses)
                .WithMany(c => c.Students)
                .Map(cs => {
                    cs.MapLeftKey("PersonId");
                    cs.MapRightKey("CourseId");
                    cs.ToTable("PersonCourse");
                });*/
        }
    }
}
