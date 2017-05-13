using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sample.Data.Abstractions;
using Sample.Entities;

namespace Sample.Data
{
    public class SampleDbContext: DbContext, ISampleDbContext
    {
        public SampleDbContext()
            : base("SampleDbConnection")
        {
            Database.SetInitializer<SampleDbContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        #region EntitySet
        public DbSet<Country> Countries { get; set; }
        public DbSet<Person> Persons { get; set; }

        public DbSet<User> Users { get; set; }
        #endregion
    }
}
