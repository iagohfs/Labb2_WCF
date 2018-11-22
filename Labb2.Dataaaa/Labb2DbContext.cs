using System;

namespace Labb2.Data
{
    public class Labb2DbContext : DbContext
    {
        public Labb2DbContext() : base("Labb2WCFDb")
        {

        }

        public DbSet<Books> Subjects { get; set; }
        public DbSet<WeekDay> WeekDays { get; set; }
        public DbSet<WeekNr> WeekNumbers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
