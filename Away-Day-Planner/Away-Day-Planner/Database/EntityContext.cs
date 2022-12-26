using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.Database
{
    internal class EntityContext : DbContext
    {
        public EntityContext() : base("name=connection-string")
        {
           // public DbSet<Ix> x { get; set;}
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
