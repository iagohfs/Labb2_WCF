using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Labb2.Data
{
    public class Labb2DbContext : DbContext
    {
        public Labb2DbContext() : base("SubjectOrganizerDb")
        {

        }

        public DbSet<Subject> Subjects { get; set; }
        public DbSet<WeekDay> WeekDays { get; set; }
        public DbSet<WeekNr> WeekNumbers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
